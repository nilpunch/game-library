using System.Collections.Generic;
using System.Linq;

namespace PhysicsSample
{
    public class PhysicWorldLinks<TAssociation> : IFrameExecution, IPhysicWorldLinks<TAssociation> where TAssociation : IActuality
    {
        private struct Association
        {
            public Association(IPhysicalObject physicalObject, TAssociation associated)
            {
                PhysicalObject = physicalObject;
                Associated = associated;
            }

            public TAssociation Associated { get; }
            public IPhysicalObject PhysicalObject { get; }
        }

        private readonly List<Association> _physicAssociations = new();

        public bool HasLink(IPhysicalObject physicalObject)
        {
            return _physicAssociations.Any(association => association.PhysicalObject == physicalObject);
        }

        public TAssociation Get(IPhysicalObject physicalObject)
        {
            return _physicAssociations.First(association => association.PhysicalObject == physicalObject).Associated;
        }

        public void Link(IPhysicalObject physicalObject, TAssociation associatedObject)
        {
            _physicAssociations.Add(new Association(physicalObject, associatedObject));
        }

        public void Unlink(IPhysicalObject key)
        {
            _physicAssociations.RemoveAll(association => association.PhysicalObject == key);
        }

        public void UnlinkAllInactual()
        {
            _physicAssociations.RemoveAll(association => !association.Associated.IsActual || !association.PhysicalObject.IsExist);
        }

        public void ExecuteFrame(long elapsedTime)
        {
            _physicAssociations.RemoveAll(association => !association.Associated.IsActual || !association.PhysicalObject.IsExist);
        }
    }
}