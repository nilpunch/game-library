namespace PhysicsSample
{
    public interface ICollidingShell
    {
        Collision CollideWith(ICollidingShell collidingShell);

        Collision CollideAgainstBox(IBoxShell boxShell);
        Collision CollideAgainstSphere(ISphereShell sphereShell);
        Collision CollideAgainstConvex(IConvexShell convexShell);
    }
}