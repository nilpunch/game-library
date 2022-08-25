using System.Collections.Generic;
using System.Linq;

namespace PhysicsSample
{
    public class PhysicWorldObjects<TAssociation> : IPhysicWorldObjects<TAssociation> where TAssociation : IReadOnlyFrameExecution
    {
        private struct PhysicalAssociation
        {
            public PhysicalAssociation(TAssociation associated, IPhysicalObject physicalObject)
            {
                PhysicalObject = physicalObject;
                Object = associated;
            }

            public TAssociation Object { get; }
            public IPhysicalObject PhysicalObject { get; }
        }

        private readonly List<PhysicalAssociation> _physicAssociations = new();
        private readonly IPhysicWorld _physicWorld;

        public PhysicWorldObjects(IPhysicWorld physicWorld)
        {
            _physicWorld = physicWorld;
        }
        
        public bool HasAssociatedObject(IPhysicalObject physicalObject)
        {
            return _physicAssociations.Any(association => association.PhysicalObject == physicalObject);
        }

        public TAssociation GetAssociatedObject(IPhysicalObject physicalObject)
        {
            return _physicAssociations.First(association => association.PhysicalObject == physicalObject).Object;
        }

        public void Add(TAssociation associatedObject, IPhysicalObject physicalObject)
        {
            _physicWorld.Add(physicalObject);
            _physicAssociations.Add(new PhysicalAssociation(associatedObject, physicalObject));
        }

        public void Remove(TAssociation associatedObject)
        {
            foreach (var association in _physicAssociations)
            {
                if (association.Object.Equals(associatedObject))
                {
                    _physicWorld.Remove(association.PhysicalObject);
                }
            }
            
            _physicAssociations.RemoveAll(association => association.Object.Equals(associatedObject));
        }

        public void RemoveAllInactual()
        {
            foreach (var association in _physicAssociations)
            {
                if (!association.Object.CanExecuteFrame)
                {
                    _physicWorld.Remove(association.PhysicalObject);
                }
            }
            
            _physicAssociations.RemoveAll(association => !association.Object.CanExecuteFrame);
        }
    }
}