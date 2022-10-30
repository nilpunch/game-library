namespace GameLibrary.Physics
{
    public interface ICollider
    {
        /// <summary>
        /// Double dispatch method.
        /// </summary>
        Collision Collide(ICollider collider);

        Collision CollideAgainstBox(Box box);
        Collision CollideAgainstSphere(Sphere sphere);
        Collision CollideAgainstConvexHull(ConvexHull convexHull);
        
        Collision CollideAgainstAABB(AABB aabb);
    }
}