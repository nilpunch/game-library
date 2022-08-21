namespace PhysicsSample
{
    public interface ICollidingShell
    {
        Collision Collide(ICollidingShell collidingShell);

        Collision CollideAgainstBox(IBoxShell boxShell);
        Collision CollideAgainstSphere(ISphereShell sphereShell);
        Collision CollideAgainstConvex(IConvexShell convexShell);
    }
}