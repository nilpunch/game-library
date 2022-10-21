using System;
using System.Collections.Generic;

namespace GameLibrary
{
    public class Simulation<TModel, TSnapshot> : ISimulation<TModel>, ISimulationTick where TModel : ISimulationModel<TSnapshot>
    {
        private readonly long _tickIntervalMilliseconds;
        private readonly long _rollbackHistoryMilliseconds;
        
        private readonly TModel _model;

        private readonly Dictionary<long, TSnapshot> _modelSnapshots = new();
        private readonly Dictionary<long, List<ICommand<TModel>>> _commandTimeline = new();

        public Simulation(TModel model, long tickIntervalMilliseconds = 20, long rollbackHistoryMilliseconds = 60000)
        {
            _model = model;
            _tickIntervalMilliseconds = tickIntervalMilliseconds;
            _rollbackHistoryMilliseconds = rollbackHistoryMilliseconds;
        }
        
        private long TickNumber { get; set; }

        private long NextTickNumber => TickNumber + 1;

        private long ElapsedMilliseconds { get; set; }

        /// <summary>
        /// All commands beyond that tick number are prediction.
        /// </summary>
        private long LastArrivedCommandTickNumber { get; set; }

        public void ExecuteTick(long elapsedMilliseconds)
        {
            ElapsedMilliseconds = elapsedMilliseconds;

            long targetTickNumber = elapsedMilliseconds / _tickIntervalMilliseconds;

            while (TickNumber < targetTickNumber)
                SimulateTick();
        }

        public void AddCommand(long tickNumber, ICommand<TModel> command, bool isPrediction = false)
        {
            if (tickNumber < 1)
                throw new ArgumentOutOfRangeException($"The {nameof(tickNumber)} must be greater than 0. {nameof(tickNumber)} = {tickNumber}");

            if (_commandTimeline.TryGetValue(tickNumber, out var commands))
                commands.Add(command);
            else
                _commandTimeline.Add(tickNumber, new List<ICommand<TModel>>() { command });

            if (!isPrediction)
                LastArrivedCommandTickNumber = tickNumber;

            if (tickNumber < NextTickNumber)
            {
                long currentTickNumber = TickNumber;
                RollbackToTick(tickNumber - 1);
                while (TickNumber < currentTickNumber)
                    SimulateTick();
            }
        }

        private void SimulateTick()
        {
            _modelSnapshots.Add(TickNumber, _model.TakeSnapshot());

            TickNumber += 1;

            if (_commandTimeline.TryGetValue(TickNumber, out List<ICommand<TModel>> commands))
                foreach (var command in commands)
                    command.Execute(_model);

            _model.ExecuteTick(_tickIntervalMilliseconds * TickNumber);
        }

        private void RollbackToTick(long tickNumber)
        {
            if (tickNumber < 0)
                throw new ArgumentOutOfRangeException($"The {nameof(tickNumber)} must not be negative. {nameof(tickNumber)} = {tickNumber}");

            if (tickNumber > TickNumber)
                throw new InvalidOperationException($"Attempting to rollBack into the future. {nameof(tickNumber)} = {tickNumber}");

            if (tickNumber == TickNumber)
                throw new InvalidOperationException($"Attempting to rollBack into the present. {nameof(tickNumber)} = {tickNumber}");

            for (long tickIterator = TickNumber - 1; tickIterator >= tickNumber; tickIterator -= 1)
                _modelSnapshots.Remove(tickIterator);

            _model.ApplySnapshot(_modelSnapshots[tickNumber]);
        }
    }
}