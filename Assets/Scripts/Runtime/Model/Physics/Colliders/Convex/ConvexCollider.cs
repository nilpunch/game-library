namespace GameLibrary.Physics
{
    public class ConvexCollider : ICollider
    {
        private readonly IConvexShell _shell;
        private readonly ICollisionsLibrary _collisionsLibrary;

        public ConvexCollider(IConvexShell shell, ICollisionsLibrary collisionsLibrary)
        {
            _shell = shell;
            _collisionsLibrary = collisionsLibrary;
        }

        public Collision Collide(ICollider collider)
        {
            return collider.CollideAgainstConvex(_shell);
        }

        public Collision CollideAgainstBox(IBoxShell boxShell)
        {
            return _collisionsLibrary.ConvexAgainstBox(_shell, boxShell);
        }

        public Collision CollideAgainstSphere(ISphereShell sphereShell)
        {
            return _collisionsLibrary.ConvexAgainstSphere(_shell, sphereShell);
        }

        public Collision CollideAgainstConvex(IConvexShell convexShell)
        {
            return _collisionsLibrary.ConvexAgainstConvex(convexShell, _shell);
        }
    }
}