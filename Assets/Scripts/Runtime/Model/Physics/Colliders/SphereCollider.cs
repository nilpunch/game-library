namespace GameLibrary.Physics
{
    public class SphereCollider : ICollider
    {
        private readonly Sphere _sphere;
        private readonly ICollisionsLibrary _collisionsLibrary;

        public SphereCollider(Sphere sphere, ICollisionsLibrary collisionsLibrary)
        {
            _sphere = sphere;
            _collisionsLibrary = collisionsLibrary;
        }

        public Collision Collide(ICollider collider)
        {
            return collider.CollideAgainstSphere(_sphere);
        }

        public Collision CollideAgainstBox(Box box)
        {
            return _collisionsLibrary.SphereAgainstBox(_sphere, box);
        }

        public Collision CollideAgainstSphere(Sphere sphere)
        {
            return _collisionsLibrary.SphereAgainstSphere(_sphere, sphere);
        }

        public Collision CollideAgainstConvexHull(ConvexHull convexHull)
        {
            return _collisionsLibrary.ConvexAgainstSphere(convexHull, _sphere);
        }

        public Collision CollideAgainstAABB(AABB aabb)
        {
            return _collisionsLibrary.AABBAgainstSphere(aabb, _sphere);
        }
    }
}