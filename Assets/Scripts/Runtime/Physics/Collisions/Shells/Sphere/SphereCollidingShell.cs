namespace GameLibrary
{
    public class SphereCollidingShell : ICollidingShell
    {
        private readonly ISphereShell _shell;
        private readonly ICollisionsLibrary _collisionsLibrary;

        public SphereCollidingShell(ISphereShell shell, ICollisionsLibrary collisionsLibrary)
        {
            _shell = shell;
            _collisionsLibrary = collisionsLibrary;
        }

        public Collision Fallback(ICollidingShell collidingShell)
        {
            return collidingShell.CollideAgainstSphere(_shell);
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