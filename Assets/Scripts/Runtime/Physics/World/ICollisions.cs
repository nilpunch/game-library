using UnityEngine;

namespace PhysicsSample
{
    public interface ICollisions
    {
        Collision CalculateCollision(IPhysicalObject physicalObject);

        Interaction[] AllInteractions();
        
        Collision Raycast(Vector3 from, Vector3 direction);
    }
}