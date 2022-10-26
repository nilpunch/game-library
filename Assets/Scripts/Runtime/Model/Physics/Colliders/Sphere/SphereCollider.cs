namespace GameLibrary
{
    public class SphereCollider : ICollider
    {
        private readonly ISphereShell _shell;
        private readonly ICollisionsLibrary _collisionsLibrary;

        public SphereCollider(ISphereShell shell, ICollisionsLibrary collisionsLibrary)
        {
            _shell = shell;
            _collisionsLibrary = collisionsLibrary;
        }

        public Collision Collide(ICollider collider)
        {
            return collider.CollideAgainstSphere(_shell);
        }

        public Collision CollideAgainstBox(IBoxShell boxShell)
        {
            return _collisionsLibrary.SphereAgainstBox(_shell, boxShell);
        }

        public Collision CollideAgainstSphere(ISphereShell sphereShell)
        {
            return _collisionsLibrary.SphereAgainstSphere(_shell, sphereShell);
        }

        public Collision CollideAgainstConvex(IConvexShell convexShell)
        {
            return _collisionsLibrary.ConvexAgainstSphere(convexShell, _shell);
        }
    }
}