﻿namespace GameLibrary.Sample
{
    public class PredictCommandsAndSendToServer<TModel> : ISimulationObject
    {
        private readonly ICommandsSource<TModel> _commandsSource;
        private readonly ISimulation<TModel> _simulation;
        private readonly IRemoteServer<TModel> _remoteServer;

        public PredictCommandsAndSendToServer(ICommandsSource<TModel> commandsSource, ISimulation<TModel> simulation, IRemoteServer<TModel> remoteServer)
        {
            _commandsSource = commandsSource;
            _simulation = simulation;
            _remoteServer = remoteServer;
        }
        
        public void Step(long elapsedMilliseconds)
        {
            while (_commandsSource.HasCommands)
            {
                var command = _commandsSource.ReadCommand();
                _simulation.AddCommand(elapsedMilliseconds, command, true);
                _remoteServer.SendCommand(elapsedMilliseconds, command);
            }
        }
    }
}