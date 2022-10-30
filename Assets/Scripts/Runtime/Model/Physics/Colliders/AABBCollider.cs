namespace GameLibrary.Physics
{
	public class AABBCollider : ICollider
	{
		private readonly AABB _aabb;
		private readonly ICollisionsLibrary _collisionsLibrary;

		public AABBCollider(AABB aabb, ICollisionsLibrary collisionsLibrary)
		{
			_aabb = aabb;
			_collisionsLibrary = collisionsLibrary;
		}
        
		public Collision Collide(ICollider collider)
		{
			return collider.CollideAgainstAABB(_aabb);
		}

		public Collision CollideAgainstBox(Box box)
		{
			return _collisionsLibrary.AABBAgainstBox(_aabb, box);
		}

		public Collision CollideAgainstSphere(Sphere sphere)
		{
			return _collisionsLibrary.AABBAgainstSphere(_aabb, sphere);
		}

		public Collision CollideAgainstConvexHull(ConvexHull convexHull)
		{
			return _collisionsLibrary.AABBAgainstConvexHull(_aabb, convexHull);
		}

		public Collision CollideAgainstAABB(AABB aabb)
		{
			return _collisionsLibrary.AABBAgainstAABB(_aabb, aabb);
		}
	}
}