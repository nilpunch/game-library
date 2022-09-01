using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace PhysicsSample
{
    public class PhysicWorld : IPhysicWorld
    {
        private readonly List<IPhysicalObject> _physicObjects = new();
        private readonly List<IPhysicalObjectsInteraction> _physicalObjectsInteractions = new();

        public PhysicWorld()
        {
        }
        
        public PhysicWorld(IPhysicalObjectsInteraction[] interactions)
        {
            _physicalObjectsInteractions = interactions.ToList();
        }
        
        public void ExecuteFrame(long elapsedTime)
        {
            _physicObjects.RemoveAll(physicObject => !physicObject.IsExist);

            // TODO:
            // 1. Broad colliders
            // 2. Collect collisions
            // 3. Solve collisiions
            // 4. Interact objects

            var physicalObjectsCollisions = new (IPhysicalObject first, IPhysicalObject second, Collision collision)[0];
            foreach (var physicalObjectsCollision in physicalObjectsCollisions)
            {
                foreach (var physicalObjectsInteraction in _physicalObjectsInteractions)
                {
                    physicalObjectsInteraction.Interact(physicalObjectsCollision.first, physicalObjectsCollision.second, physicalObjectsCollision.collision);
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
            
            foreach (var simulatedObject in _physicObjects.Where(obj => !obj.Equals(physicalObject) && obj.Tag == againstTagged))
                collision = collision.Merge(simulatedObject.Shell.Fallback(physicalObject.Shell));

            return collision;
        }

        public Collision Raycast(Vector3 from, Vector3 direction, string againstTagged)
        {
            throw new NotImplementedException();
        }
    }
}