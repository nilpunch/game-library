namespace GameLibrary
{
    public interface ICollisionsWorld
    {
        Interaction[] AllInteractions();
        
        Interaction[] InteractWith(IPhysicalObject physicalObject);

        RaycastHit Raycast(Vector3 from, Vector3 direction);
    }
}