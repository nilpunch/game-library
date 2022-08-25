using System;
using System.Collections.Generic;
using System.Linq;

namespace PhysicsSample
{
    public class PhysicWorld : IPhysicWorld
    {
        private readonly List<IPhysicalObject> _physicObjects = new();
        private readonly List<IPhysicalObjectsInteraction> _physicalObjectsInteractions = new();

        public bool CanExecuteFrame => true;

        public void ExecuteFrame(long elapsedTime)
        {
            // TODO:
            // 1. Broad colliders
            // 2. Collect collisions
            // 3. Solve collisiions
            // 4. Interact objects

            var physicalObjectsCollisions = new (IPhysicalObject, IPhysicalObject, Collision)[0];
            foreach (var physicalObjectsCollision in physicalObjectsCollisions)
            {
                foreach (var physicalObjectsInteraction in _physicalObjectsInteractions)
                {
                    physicalObjectsInteraction.Interact(physicalObjectsCollision.Item1, physicalObjectsCollision.Item2, physicalObjectsCollision.Item3);
                }
            }
            
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

        public void AddInteraction(IPhysicalObjectsInteraction physicalObjectsInteraction)
        {
            _physicalObjectsInteractions.Add(physicalObjectsInteraction);
        }

        public void RemoveInteraction(IPhysicalObjectsInteraction physicalObjectsInteraction)
        {
            _physicalObjectsInteractions.Remove(physicalObjectsInteraction);
        }

        public Collision CalculateCollision(IPhysicalObject physicalObject, string againstTagged)
        {
            Collision collision = new Collision();
            
            foreach (var simulatedObject in _physicObjects.Where(obj => !obj.Equals(physicalObject)))
                collision = collision.Merge(simulatedObject.Shell.CollideWith(physicalObject.Shell));

            return collision;
        }
    }
}