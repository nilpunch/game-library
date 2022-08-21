using System;
using System.Collections.Generic;
using System.Linq;

namespace PhysicsSample
{
    public class PhysicWorld : IPhysicWorld
    {
        private readonly List<IPhysicalObject> _physicObjects = new();

        public bool CanExecuteFrame => true;

        public void ExecuteFrame(long time)
        {
            // TODO: Collect collisions, solve them.
            throw new NotImplementedException();
        }

        public void Add(IPhysicalObject physicalObject)
        {
            _physicObjects.Add(physicalObject);
        }

        public void Remove(IPhysicalObject physicalObject)
        {
            _physicObjects.Remove(physicalObject);
        }

        public Collision CalculateCollision(IPhysicalObject physicalObject, string againstTagged)
        {
            Collision collision = new Collision();
            
            foreach (var simulatedObject in _physicObjects.Where(obj => !obj.Equals(physicalObject)))
                collision = collision.Merge(simulatedObject.Shell.Collide(physicalObject.Shell));

            return collision;
        }
    }
}