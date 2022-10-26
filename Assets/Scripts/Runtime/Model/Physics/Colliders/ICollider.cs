namespace GameLibrary
{
    public interface ICollider
    {
        Collision Collide(ICollider collider);

        Collision CollideAgainstBox(IBoxShell boxShell);
        Collision CollideAgainstSphere(ISphereShell sphereShell);
        Collision CollideAgainstConvex(IConvexShell convexShell);
    }
}