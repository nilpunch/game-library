using GameLibrary.Mathematics;

namespace GameLibrary.Physics
{
    public class CollisionsLibrary : ICollisionsLibrary
    {
        public Collision BoxAgainstBox(Box first, Box second)
        {
            throw new System.NotImplementedException();
        }

        public Collision SphereAgainstBox(Sphere first, Box second)
        {
            throw new System.NotImplementedException();
        }

        public Collision SphereAgainstSphere(Sphere first, Sphere second)
        {
            throw new System.NotImplementedException();
        }

        public Collision ConvexAgainstBox(ConvexHull first, Box second)
        {
            throw new System.NotImplementedException();
        }

        public Collision ConvexAgainstSphere(ConvexHull first, Sphere second)
        {
            throw new System.NotImplementedException();
        }

        public Collision ConvexAgainstConvex(ConvexHull first, ConvexHull second)
        {
            throw new System.NotImplementedException();
        }

        public Collision AABBAgainstBox(AABB first, Box second)
        {
            throw new System.NotImplementedException();
        }

        public Collision AABBAgainstSphere(AABB first, Sphere second)
        {
            throw new System.NotImplementedException();
        }

        public Collision AABBAgainstConvexHull(AABB first, ConvexHull second)
        {
            throw new System.NotImplementedException();
        }

        public Collision AABBAgainstAABB(AABB first, AABB second)
        {
            throw new System.NotImplementedException();
        }
    }
}