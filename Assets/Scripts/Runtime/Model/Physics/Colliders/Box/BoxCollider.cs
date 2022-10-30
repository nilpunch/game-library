namespace GameLibrary.Physics
{
    public class BoxCollider : ICollider
    {
        private readonly IBoxShell _shell;
        private readonly ICollisionsLibrary _collisionsLibrary;

        public BoxCollider(IBoxShell shell, ICollisionsLibrary collisionsLibrary)
        {
            _shell = shell;
            _collisionsLibrary = collisionsLibrary;
        }

        public Collision Collide(ICollider collider)
        {
            return collider.CollideAgainstBox(_shell);
        }

        public Collision CollideAgainstBox(IBoxShell boxShell)
        {
            return _collisionsLibrary.BoxAgainstBox(_shell, boxShell);
        }

        public Collision CollideAgainstSphere(ISphereShell sphereShell)
        {
            return _collisionsLibrary.SphereAgainstBox(sphereShell, _shell);
        }

        public Collision CollideAgainstConvex(IConvexShell convexShell)
        {
            return _collisionsLibrary.ConvexAgainstBox(convexShell, _shell);
        }
    }
}