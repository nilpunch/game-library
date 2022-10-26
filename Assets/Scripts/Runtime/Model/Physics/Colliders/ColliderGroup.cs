namespace GameLibrary
{
    public class ColliderGroup : ICollider
    {
        private readonly ICollider[] _collidingShells;

        public ColliderGroup(ICollider[] collidingShells)
        {
            _collidingShells = collidingShells;
        }

        public Collision Collide(ICollider collider)
        {
            Collision collision = new Collision();

            foreach (var shell in _collidingShells)
                collision = collision.Merge(shell.Collide(collider));

            return collision;
        }

        public Collision CollideAgainstBox(IBoxShell boxShell)
        {
            Collision collision = new Collision();

            foreach (var shell in _collidingShells)
                collision = collision.Merge(shell.CollideAgainstBox(boxShell));

            return collision;
        }

        public Collision CollideAgainstSphere(ISphereShell sphereShell)
        {
            Collision collision = new Collision();

            foreach (var shell in _collidingShells)
                collision = collision.Merge(shell.CollideAgainstSphere(sphereShell));

            return collision;
        }

        public Collision CollideAgainstConvex(IConvexShell convexShell)
        {
            Collision collision = new Collision();

            foreach (var shell in _collidingShells)
            {
                collision = collision.Merge(shell.CollideAgainstConvex(convexShell));
            }

            return collision;
        }
    }
}