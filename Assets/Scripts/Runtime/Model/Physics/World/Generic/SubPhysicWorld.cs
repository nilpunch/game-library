using System;
using System.Collections.Generic;
using System.Linq;
using GameLibrary.Lifetime;
using GameLibrary.Math;

namespace GameLibrary.Physics
{
    public class SubPhysicWorld<TConcrete> : IPhysicWorld<TConcrete>, IDeadObjectsStorage where TConcrete : IAlive
    {
        private readonly List<PhysicalPair<TConcrete>> _physicalPairs = new();
        private readonly List<CollisionManifold<TConcrete>> _manifolds = new();

        private readonly IPhysicWorld _parent;

        public SubPhysicWorld(IPhysicWorld parent)
        {
            _parent = parent;
        }

        public void Add(IRigidbody rigidbody, TConcrete concreteObject)
        {
            _parent.Add(rigidbody);
            _physicalPairs.Add(new PhysicalPair<TConcrete>(rigidbody, concreteObject));
        }

        public void Remove(IRigidbody rigidbody)
        {
            _parent.Remove(rigidbody);
            _physicalPairs.RemoveAll(physicalLink => physicalLink.Rigidbody == rigidbody);
        }

        public void ExecuteTick(long elapsedMilliseconds)
        {
            throw new NotImplementedException();
        }

        public void CleanupDeadObjects()
        {
            _physicalPairs.RemoveAll(association =>
                !association.Concrete.IsAlive || !association.Rigidbody.IsAlive);
        }

        public CollisionManifold<TConcrete>[] CollisionsWith(IRigidbody rigidbody)
        {
            throw new NotImplementedException();
        }

        public RaycastHit<TConcrete> Raycast(Float3 from, Float3 direction)
        {
            RaycastHit raycastHit = _parent.Raycast(from, direction);

            throw new NotImplementedException();

            if (raycastHit.Occure && HasLinkedObject(raycastHit.Rigidbody))
            {
                return new RaycastHit<TConcrete>();
            }
        }

        private bool HasLinkedObject(IRigidbody rigidbody)
        {
            return _physicalPairs.Any(association => association.Rigidbody == rigidbody);
        }

        private TConcrete GetLinkedObject(IRigidbody rigidbody)
        {
            return _physicalPairs.First(association => association.Rigidbody == rigidbody).Concrete;
        }
    }
}
