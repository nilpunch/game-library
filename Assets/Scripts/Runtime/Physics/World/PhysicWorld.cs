using System;
using System.Collections.Generic;
using System.Linq;


namespace GameLibrary
{
    public class PhysicWorld : IPhysicWorld
    {
        private readonly List<IPhysicalObject> _physicObjects = new();

        public void ExecuteFrame(long elapsedTime)
        {
            _physicObjects.RemoveAll(physicObject => !physicObject.IsExist);

            // TODO:
            // 1. Broad colliders
            // 2. Collect collisions
            // 3. Solve collisions

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

        public Collision CalculateCollision(IPhysicalObject physicalObject)
        {
            Collision collision = new Collision();

            foreach (var simulatedObject in _physicObjects.Where(obj => !obj.Equals(physicalObject)))
                collision = collision.Merge(simulatedObject.Shell.Fallback(physicalObject.Shell));

            return collision;
        }

        public Interaction[] AllInteractions()
        {
            throw new NotImplementedException();
        }

        public Collision Raycast(Vector3 from, Vector3 direction)
        {
            throw new NotImplementedException();
        }
    }
}