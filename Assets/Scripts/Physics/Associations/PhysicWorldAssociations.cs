using System.Collections.Generic;

namespace PhysicsSample
{
    public class PhysicWorldAssociations<T> : IPhysicWorldAssociations<T>
    {
        private readonly Dictionary<IPhysicalObject, T> _physicAssociations = new();

        public bool HasAssociatedObject(IPhysicalObject physicalObject)
        {
            return _physicAssociations.ContainsKey(physicalObject);
        }

        public T GetAssociatedObject(IPhysicalObject physicalObject)
        {
            return _physicAssociations[physicalObject];
        }

        public void Add(IPhysicalObject physicalObject, T associatedObject)
        {
            _physicAssociations.Add(physicalObject, associatedObject);
        }

        public void Remove(IPhysicalObject physicalObject)
        {
            _physicAssociations.Remove(physicalObject);
        }
    }
}