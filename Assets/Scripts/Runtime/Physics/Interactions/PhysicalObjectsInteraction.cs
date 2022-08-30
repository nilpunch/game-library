namespace PhysicsSample
{
    public class PhysicalObjectsInteraction<TFirst, TSecond> : IPhysicalObjectsInteraction
    {
        private readonly IReadOnlyAssociations<IPhysicalObject, TFirst> _firstObjects;
        private readonly IReadOnlyAssociations<IPhysicalObject, TSecond> _secondObjects;
        private readonly IObjectsInteraction<TFirst, TSecond> _objectsInteraction;

        public PhysicalObjectsInteraction(IReadOnlyAssociations<IPhysicalObject, TFirst> firstObjects,
            IReadOnlyAssociations<IPhysicalObject, TSecond> secondObjects,
            IObjectsInteraction<TFirst, TSecond> objectsInteraction)
        {
            _firstObjects = firstObjects;
            _secondObjects = secondObjects;
            _objectsInteraction = objectsInteraction;
        }
        
        public void Interact(IPhysicalObject first, IPhysicalObject second, Collision collision)
        {
            if (_firstObjects.HasAssociation(first) && _secondObjects.HasAssociation(second))
            {
                _objectsInteraction.Interact(_firstObjects.GetAssociation(first), _secondObjects.GetAssociation(second), collision);
            }
        }
    }
}