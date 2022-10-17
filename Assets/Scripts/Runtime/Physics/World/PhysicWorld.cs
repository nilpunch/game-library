using System;
using System.Collections.Generic;
using System.Linq;


namespace GameLibrary
{
    public class PhysicWorld : IPhysicWorld, ISimulationTick
    {
        private readonly List<IPhysicalObject> _physicObjects = new();
        private readonly List<Interaction> _interactions = new();

        public void ExecuteTick(long elapsedMilliseconds)
        {
            _physicObjects.RemoveAll(physicObject => !physicObject.IsAlive);

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

        public Interaction[] InteractWith(IPhysicalObject physicalObject)
        {
            Collision collision = new Collision();

            foreach (var simulatedObject in _physicObjects.Where(obj => !obj.Equals(physicalObject)))
                collision = collision.Merge(simulatedObject.Shell.Fallback(physicalObject.Shell));

            return Array.Empty<Interaction>();
        }

        public Interaction[] AllInteractions()
        {
            throw new NotImplementedException();
        }

        public RaycastHit Raycast(Vector3 from, Vector3 direction)
        {
            throw new NotImplementedException();
        }
    }
}