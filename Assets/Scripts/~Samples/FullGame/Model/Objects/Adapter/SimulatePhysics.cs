using GameLibrary.Physics;

namespace GameLibrary.Sample
{
    public class SimulatePhysics : ISimulationObject
    {
        private readonly ISimulate _simulate;

        public SimulatePhysics(ISimulate simulate)
        {
            _simulate = simulate;
        }

        public void Step(long elapsedMilliseconds)
        {
            _simulate.Step(elapsedMilliseconds);
        }
    }
}
