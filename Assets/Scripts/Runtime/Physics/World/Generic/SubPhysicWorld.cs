using System;
using System.Collections.Generic;
using System.Linq;

namespace GameLibrary
{
    public class SubPhysicWorld<TConcrete> : IPhysicWorld<TConcrete>, ISimulationTick where TConcrete : IAlive
    {
        private readonly List<PhysicalPair<TConcrete>> _physicalPairs = new();
        private readonly List<Interaction<TConcrete>> _interactions = new();

        private readonly IPhysicWorld _parent;

        public SubPhysicWorld(IPhysicWorld parent)
        {
            _parent = parent;
        }

        public void Add(IPhysicalObject physicalObject, TConcrete concreteObject)
        {
            _parent.Add(physicalObject);
            _physicalPairs.Add(new PhysicalPair<TConcrete>(physicalObject, concreteObject));
        }

        public void Remove(IPhysicalObject physicalObject)
        {
            _parent.Remove(physicalObject);
            _physicalPairs.RemoveAll(physicalLink => physicalLink.PhysicalObject == physicalObject);
        }
        
        public void ExecuteTick(long elapsedMilliseconds)
        {
            // Removing all dead
            _physicalPairs.RemoveAll(association =>
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
            RaycastHit raycastHit = _parent.Raycast(from, direction);

            throw new NotImplementedException();
            
            if (raycastHit.Occure && HasLinkedObject(raycastHit.PhysicalObject))
            {
                return new RaycastHit<TConcrete>();
            }
        }

        private bool HasLinkedObject(IPhysicalObject physicalObject)
        {
            return _physicalPairs.Any(association => association.PhysicalObject == physicalObject);
        }

        private TConcrete GetLinkedObject(IPhysicalObject physicalObject)
        {
            return _physicalPairs.First(association => association.PhysicalObject == physicalObject).Concrete;
        }
    }
}