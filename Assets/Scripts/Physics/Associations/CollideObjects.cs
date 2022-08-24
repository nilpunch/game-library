using System.Collections.Generic;
using System.Linq;

namespace PhysicsSample
{
    public class CollideObjects<T> : ICollideObjects<T>, IActualization where T : IReadOnlyFrameExecution
    {
        private readonly IPhysicWorld _physicWorld;

        private struct PhysicAssociation
        {
            public PhysicAssociation(T associated, IPhysicalObject physicalObject)
            {
                PhysicalObject = physicalObject;
                Object = associated;
            }

            public T Object { get; }
            public IPhysicalObject PhysicalObject { get; }
        }
        
        private readonly List<PhysicAssociation> _physicAssociations = new();

        public CollideObjects(IPhysicWorld physicWorld)
        {
            _physicWorld = physicWorld;
        }
        
        public bool HasAssociatedObject(IPhysicalObject physicalObject)
        {
            return _physicAssociations.Any(association => association.PhysicalObject == physicalObject);
        }

        public T GetAssociatedObject(IPhysicalObject physicalObject)
        {
            return _physicAssociations.First(association => association.PhysicalObject == physicalObject).Object;
        }

        public void Add(T associatedObject, IPhysicalObject physicalObject)
        {
            _physicWorld.Add(physicalObject);
            _physicAssociations.Add(new PhysicAssociation(associatedObject, physicalObject));
        }

        public void Remove(T associatedObject)
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