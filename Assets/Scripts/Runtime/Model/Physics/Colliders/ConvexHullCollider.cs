namespace GameLibrary.Physics
{
    public class ConvexHullCollider : ICollider
    {
        private readonly ConvexHull _convexHull;
        private readonly ICollisionsLibrary _collisionsLibrary;

        public ConvexHullCollider(ConvexHull convexHull, ICollisionsLibrary collisionsLibrary)
        {
            _convexHull = convexHull;
            _collisionsLibrary = collisionsLibrary;
        }

        public Collision Collide(ICollider collider)
        {
            return collider.CollideAgainstConvexHull(_convexHull);
        }

        public Collision CollideAgainstBox(Box box)
        {
            return _collisionsLibrary.ConvexAgainstBox(_convexHull, box);
        }

        public Collision CollideAgainstSphere(Sphere sphere)
        {
            return _collisionsLibrary.ConvexAgainstSphere(_convexHull, sphere);
        }

        public Collision CollideAgainstConvexHull(ConvexHull convexHull)
        {
            return _collisionsLibrary.ConvexAgainstConvex(convexHull, _convexHull);
        }

        public Collision CollideAgainstAABB(AABB aabb)
        {
            return _collisionsLibrary.AABBAgainstConvexHull(aabb, _convexHull);
        }
    }
}