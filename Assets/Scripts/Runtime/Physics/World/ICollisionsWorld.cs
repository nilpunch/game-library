namespace GameLibrary
{
    public interface ICollisionsWorld
    {
        Interaction[] AllInteractions();
        
        Collision CalculateCollision(IPhysicalObject physicalObject);

        Collision Raycast(Vector3 from, Vector3 direction);
    }
}