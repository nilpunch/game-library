namespace GameLibrary
{
    public interface ICollisionsWorld
    {
        Interaction[] AllInteractions();
        
        Collision CalculateCollision(IPhysicalObject physicalObject);

        RaycastHit Raycast(Vector3 from, Vector3 direction);
    }
}