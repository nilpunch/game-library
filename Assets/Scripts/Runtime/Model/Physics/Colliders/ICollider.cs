namespace GameLibrary.Physics
{
    public interface ICollider
    {
        /// <summary>
        /// Double dispatch method.
        /// </summary>
        Collision Collide(ICollider collider);

        Collision CollideAgainstBox(IBoxShell boxShell);
        Collision CollideAgainstSphere(ISphereShell sphereShell);
        Collision CollideAgainstConvex(IConvexShell convexShell);
    }
}