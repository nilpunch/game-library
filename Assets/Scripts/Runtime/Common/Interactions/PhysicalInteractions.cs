namespace GameLibrary
{
    public class PhysicalInteractions<TFirst, TSecond> : IFrameExecution
    {
        private readonly ICollisionsWorld _collisionsWorld;
        private readonly IReadOnlyPhysicWorldObjects<TFirst> _firstWorldObjects;
        private readonly IReadOnlyPhysicWorldObjects<TSecond> _secondWorldObjects;
        private readonly IObjectsInteraction<TFirst, TSecond> _objectsInteraction;

        public PhysicalInteractions(ICollisionsWorld collisionsWorld, 
            IReadOnlyPhysicWorldObjects<TFirst> firstWorldObjects,
            IReadOnlyPhysicWorldObjects<TSecond> secondWorldObjects,
            IObjectsInteraction<TFirst, TSecond> objectsInteraction)
        {
            _collisionsWorld = collisionsWorld;
            _firstWorldObjects = firstWorldObjects;
            _secondWorldObjects = secondWorldObjects;
            _objectsInteraction = objectsInteraction;
        }

        public void ExecuteFrame(long elapsedTime)
        {
            foreach (var interaction in _collisionsWorld.AllInteractions())
            {
                if (_firstWorldObjects.HasLink(interaction.First) && _secondWorldObjects.HasLink(interaction.Second))
                {
                    _objectsInteraction.Interact(_firstWorldObjects.Get(interaction.First),
                        _secondWorldObjects.Get(interaction.Second), interaction.Collision);
                }
            }
        }
    }
}