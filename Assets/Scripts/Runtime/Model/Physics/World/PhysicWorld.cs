using System;
using System.Collections.Generic;
using System.Linq;
using GameLibrary.Lifetime;
using GameLibrary.Math;


namespace GameLibrary.Physics
{
    public class PhysicWorld : IPhysicWorld, ISimulationObject, IDeadObjectsStorage
    {
        private readonly List<IRigidbody> _rigidbodies = new();
        private readonly List<CollisionManifold> _manifolds = new();

        public void Step(long elapsedMilliseconds)
        {
            // TODO:
            // 1. Broad colliders
            // 2. Collect collisions
            // 3. Solve collisions

            throw new NotImplementedException();
        }

        public void Add(IRigidbody rigidbody)
        {
            _rigidbodies.Add(rigidbody);
        }

        public void Remove(IRigidbody rigidbody)
        {
            _rigidbodies.Remove(rigidbody);
        }

        public void CleanupDeadObjects()
        {
            _rigidbodies.RemoveAll(physicObject => !physicObject.IsAlive);
        }

        public CollisionManifold[] CollisionsWith(IRigidbody rigidbody)
        {
            Collision collision = new Collision();

            foreach (var simulatedObject in _rigidbodies.Where(obj => !obj.Equals(rigidbody)))
                collision = collision.Merge(simulatedObject.Collider.Collide(rigidbody.Collider));

            return Array.Empty<CollisionManifold>();
        }

        public RaycastHit Raycast(Float3 from, Float3 direction)
        {
            throw new NotImplementedException();
        }
    }
}
