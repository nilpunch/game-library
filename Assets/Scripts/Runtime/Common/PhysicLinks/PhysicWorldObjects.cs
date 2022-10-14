using System.Collections.Generic;
using System.Linq;

namespace GameLibrary
{
    public class PhysicWorldObjects<TAssociation> : ISimulationTick, IPhysicWorldObjects<TAssociation>
        where TAssociation : IAlive
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

        public bool HasLinkedObject(IPhysicalObject physicalObject)
        {
            return _physicAssociations.Any(association => association.PhysicalObject == physicalObject);
        }

        public TAssociation GetLinkedObject(IPhysicalObject physicalObject)
        {
            return _physicAssociations.First(association => association.PhysicalObject == physicalObject).Associated;
        }

        public void Link(IPhysicalObject physicalObject, TAssociation linkedObject)
        {
            _physicAssociations.Add(new Association(physicalObject, linkedObject));
        }

        public void Unlink(IPhysicalObject physicalObject)
        {
            _physicAssociations.RemoveAll(association => association.PhysicalObject == physicalObject);
        }

        public void ExecuteTick(long elapsedMilliseconds)
        {
            _physicAssociations.RemoveAll(association =>
                !association.Associated.IsAlive || !association.PhysicalObject.IsAlive);
        }
    }
}