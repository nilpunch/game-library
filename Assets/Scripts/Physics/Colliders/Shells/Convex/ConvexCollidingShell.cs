namespace PhysicsSample
{
    public class ConvexCollidingShell : ICollidingShell
    {
        private readonly IConvexShell _shell;
        private readonly ICollisionsLibrary _collisionsLibrary;

        public ConvexCollidingShell(IConvexShell shell, ICollisionsLibrary collisionsLibrary)
        {
            _shell = shell;
            _collisionsLibrary = collisionsLibrary;
        }
        
        public Collision Collide(ICollidingShell collidingShell)
        {
            return collidingShell.CollideAgainstConvex(_shell);
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