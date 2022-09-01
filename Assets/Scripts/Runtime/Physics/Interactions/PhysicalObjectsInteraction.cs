namespace PhysicsSample
{
    public class PhysicalObjectsInteraction<TFirst, TSecond> : IPhysicalObjectsInteraction
    {
        private readonly IReadOnlyPhysicWorldLinks<TFirst> _firstLinks;
        private readonly IReadOnlyPhysicWorldLinks<TSecond> _secondLinks;
        private readonly IObjectsInteraction<TFirst, TSecond> _objectsInteraction;

        public PhysicalObjectsInteraction(IReadOnlyPhysicWorldLinks<TFirst> firstLinks,
            IReadOnlyPhysicWorldLinks<TSecond> secondLinks,
            IObjectsInteraction<TFirst, TSecond> objectsInteraction)
        {
            _firstLinks = firstLinks;
            _secondLinks = secondLinks;
            _objectsInteraction = objectsInteraction;
        }
        
        public void Interact(IPhysicalObject first, IPhysicalObject second, Collision collision)
        {
            if (_firstLinks.HasLink(first) && _secondLinks.HasLink(second))
            {
                _objectsInteraction.Interact(_firstLinks.Get(first), _secondLinks.Get(second), collision);
            }
        }
    }
}