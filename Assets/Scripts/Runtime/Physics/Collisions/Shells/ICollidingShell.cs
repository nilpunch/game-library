namespace GameLibrary
{
    public interface ICollidingShell
    {
        Collision Fallback(ICollidingShell collidingShell);

        Collision CollideAgainstBox(IBoxShell boxShell);
        Collision CollideAgainstSphere(ISphereShell sphereShell);
        Collision CollideAgainstConvex(IConvexShell convexShell);
    }
}