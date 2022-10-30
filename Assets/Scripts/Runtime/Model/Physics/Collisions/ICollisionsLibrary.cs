namespace GameLibrary.Physics
{
    public interface ICollisionsLibrary
    {
        Collision BoxAgainstBox(Box first, Box second);

        Collision SphereAgainstBox(Sphere first, Box second);
        Collision SphereAgainstSphere(Sphere first, Sphere second);

        Collision ConvexAgainstBox(ConvexHull first, Box second);
        Collision ConvexAgainstSphere(ConvexHull first, Sphere second);
        Collision ConvexAgainstConvex(ConvexHull first, ConvexHull second);

        Collision AABBAgainstBox(AABB first, Box second);
        Collision AABBAgainstSphere(AABB first, Sphere second);
        Collision AABBAgainstConvexHull(AABB first, ConvexHull second);
        Collision AABBAgainstAABB(AABB first, AABB second);
    }
}