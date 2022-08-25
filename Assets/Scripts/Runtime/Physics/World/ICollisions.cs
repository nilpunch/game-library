using UnityEngine;

namespace PhysicsSample
{
    public interface ICollisions
    {
        Collision CalculateCollision(IPhysicalObject physicalObject, string againstTagged);

        Collision Raycast(Vector3 from, Vector3 direction, string againstTagged);
    }
}