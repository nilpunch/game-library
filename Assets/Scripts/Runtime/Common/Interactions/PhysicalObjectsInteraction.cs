namespace GameLibrary
{
    public class PhysicalObjectsInteraction<TFirst, TSecond> : IFrameExecution
    {
        private readonly ICollisionsWorld _collisionsWorld;
        private readonly IPhysicWorldLinks<TFirst> _firstLinks;
        private readonly IPhysicWorldLinks<TSecond> _secondLinks;
        private readonly IObjectsInteraction<TFirst, TSecond> _objectsInteraction;

        public PhysicalObjectsInteraction(ICollisionsWorld collisionsWorld, IPhysicWorldLinks<TFirst> firstLinks,
            IPhysicWorldLinks<TSecond> secondLinks,
            IObjectsInteraction<TFirst, TSecond> objectsInteraction)
        {
            _collisionsWorld = collisionsWorld;
            _firstLinks = firstLinks;
            _secondLinks = secondLinks;
            _objectsInteraction = objectsInteraction;
        }

        public void ExecuteFrame(long elapsedTime)
        {
            foreach (var interaction in _collisionsWorld.AllInteractions())
            {
                if (_firstLinks.HasLink(interaction.First) && _secondLinks.HasLink(interaction.Second))
                {
                    _objectsInteraction.Interact(_firstLinks.Get(interaction.First),
                        _secondLinks.Get(interaction.Second), interaction.Collision);
                }
            }
        }
    }
}