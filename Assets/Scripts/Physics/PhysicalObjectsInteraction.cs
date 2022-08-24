namespace PhysicsSample
{
    public class PhysicalObjectsInteraction<TFirst, TSecond> : IPhysicalObjectsInteraction
    {
        private readonly IReadOnlyCollideObjects<TFirst> _firstObject;
        private readonly IReadOnlyCollideObjects<TSecond> _secondObjects;
        private readonly IObjectsInteraction<TFirst, TSecond> _objectsInteraction;

        public PhysicalObjectsInteraction(IReadOnlyCollideObjects<TFirst> firstObject,
            IReadOnlyCollideObjects<TSecond> secondObjects,
            IObjectsInteraction<TFirst, TSecond> objectsInteraction)
        {
            _firstObject = firstObject;
            _secondObjects = secondObjects;
            _objectsInteraction = objectsInteraction;
        }
        
        public void Interact(IPhysicalObject first, IPhysicalObject second, Collision collision)
        {
            if (_firstObject.HasAssociatedObject(first) && _secondObjects.HasAssociatedObject(second))
            {
                _objectsInteraction.Interact(_firstObject.GetAssociatedObject(first), _secondObjects.GetAssociatedObject(second), collision);
            }
        }
    }
}