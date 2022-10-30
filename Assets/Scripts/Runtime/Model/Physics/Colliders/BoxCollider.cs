namespace GameLibrary.Physics
{
    public class BoxCollider : ICollider
    {
        private readonly Box _box;
        private readonly ICollisionsLibrary _collisionsLibrary;

        public BoxCollider(Box box, ICollisionsLibrary collisionsLibrary)
        {
            _box = box;
            _collisionsLibrary = collisionsLibrary;
        }

        public Collision Collide(ICollider collider)
        {
            return collider.CollideAgainstBox(_box);
        }

        public Collision CollideAgainstBox(Box box)
        {
            return _collisionsLibrary.BoxAgainstBox(_box, box);
        }

        public Collision CollideAgainstSphere(Sphere sphere)
        {
            return _collisionsLibrary.SphereAgainstBox(sphere, _box);
        }

        public Collision CollideAgainstConvexHull(ConvexHull convexHull)
        {
            return _collisionsLibrary.ConvexAgainstBox(convexHull, _box);
        }

        public Collision CollideAgainstAABB(AABB aabb)
        {
            return _collisionsLibrary.AABBAgainstBox(aabb, _box);
        }
    }
}