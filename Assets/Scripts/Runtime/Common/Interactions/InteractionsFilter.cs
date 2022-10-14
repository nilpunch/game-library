namespace GameLibrary
{
    public class InteractionsFilter<TFirst, TSecond> : ISimulationTick
    {
        private readonly ICollisionsWorld _collisionsWorld;
        private readonly IReadOnlyPhysicWorldObjects<TFirst> _firstWorldObjects;
        private readonly IReadOnlyPhysicWorldObjects<TSecond> _secondWorldObjects;
        private readonly IObjectsInteraction<TFirst, TSecond> _objectsInteraction;

        public InteractionsFilter(ICollisionsWorld collisionsWorld, 
            IReadOnlyPhysicWorldObjects<TFirst> firstWorldObjects,
            IReadOnlyPhysicWorldObjects<TSecond> secondWorldObjects,
            IObjectsInteraction<TFirst, TSecond> objectsInteraction)
        {
            _collisionsWorld = collisionsWorld;
            _firstWorldObjects = firstWorldObjects;
            _secondWorldObjects = secondWorldObjects;
            _objectsInteraction = objectsInteraction;
        }

        public void ExecuteTick(long elapsedMilliseconds)
        {
            foreach (var interaction in _collisionsWorld.AllInteractions())
            {
                if (_firstWorldObjects.HasLinkedObject(interaction.First) && _secondWorldObjects.HasLinkedObject(interaction.Second))
                {
                    _objectsInteraction.Interact(_firstWorldObjects.GetLinkedObject(interaction.First),
                        _secondWorldObjects.GetLinkedObject(interaction.Second), interaction.Collision);
                }
            }
        }
    }
}