using System;
using System.Collections.Generic;
using System.Linq;

namespace GameLibrary
{
    public class PhysicSubWorld<TConcrete> : IPhysicSubWorld<TConcrete> where TConcrete : IAlive
    {
        private struct PhysicalLink
        {
            public PhysicalLink(IPhysicalObject physicalObject, TConcrete concrete)
            {
                PhysicalObject = physicalObject;
                Concrete = concrete;
            }

            public TConcrete Concrete { get; }
            public IPhysicalObject PhysicalObject { get; }
        }

        private readonly List<PhysicalLink> _physicalLinks = new();
        private readonly List<Interaction<TConcrete>> _interactions = new();

        private readonly IPhysicWorld _originalWorld;

        public PhysicSubWorld(IPhysicWorld originalWorld)
        {
            _originalWorld = originalWorld;
        }

        public void Add(IPhysicalObject physicalObject, TConcrete concreteObject)
        {
            _originalWorld.Add(physicalObject);
            _physicalLinks.Add(new PhysicalLink(physicalObject, concreteObject));
        }

        public void Remove(IPhysicalObject physicalObject)
        {
            _originalWorld.Remove(physicalObject);
            _physicalLinks.RemoveAll(physicalLink => physicalLink.PhysicalObject == physicalObject);
        }

        public void CleanAllDead()
        {
            _physicalLinks.RemoveAll(association =>
                !association.Concrete.IsAlive || !association.PhysicalObject.IsAlive);
        }

        public Interaction<TConcrete>[] AllInteractions()
        {
            throw new NotImplementedException();
        }

        public Interaction<TConcrete>[] InteractionsWith(IPhysicalObject physicalObject)
        {
            throw new NotImplementedException();
        }

        public RaycastHit<TConcrete> Raycast(Vector3 from, Vector3 direction)
        {
            RaycastHit raycastHit = _originalWorld.Raycast(from, direction);

            throw new NotImplementedException();
            
            if (raycastHit.Occure && HasLinkedObject(raycastHit.PhysicalObject))
            {
                return new RaycastHit<TConcrete>();
            }
        }

        private bool HasLinkedObject(IPhysicalObject physicalObject)
        {
            return _physicalLinks.Any(association => association.PhysicalObject == physicalObject);
        }

        private TConcrete GetLinkedObject(IPhysicalObject physicalObject)
        {
            return _physicalLinks.First(association => association.PhysicalObject == physicalObject).Concrete;
        }
    }
}