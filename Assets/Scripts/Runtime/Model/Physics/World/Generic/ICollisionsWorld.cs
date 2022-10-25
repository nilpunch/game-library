using GameLibrary.Math;

namespace GameLibrary
{
    public interface ICollisionsWorld<TConcrete>
    {
        Interaction<TConcrete>[] AllInteractions();
        
        Interaction<TConcrete>[] InteractionsWith(IPhysicalObject physicalObject);
        
        RaycastHit<TConcrete> Raycast(Vector3 from, Vector3 direction);
    }
}