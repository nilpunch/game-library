namespace PhysicsSample
{
    public class ActualizationGroup : IActualization
    {
        private readonly IActualization[] _actualizations;

        public ActualizationGroup(IActualization[] actualizations)
        {
            _actualizations = actualizations;
        }
        
        public void RemoveAllInactual()
        {
            foreach (var actualization in _actualizations)
            {
                actualization.RemoveAllInactual();
            }
        }
    }
}