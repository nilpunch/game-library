namespace PhysicsSample
{
    public class BoxCollidingShell : ICollidingShell
    {
        private readonly IBoxShell _shell;
        private readonly ICollisionsLibrary _collisionsLibrary;

        public BoxCollidingShell(IBoxShell shell, ICollisionsLibrary collisionsLibrary)
        {
            _shell = shell;
            _collisionsLibrary = collisionsLibrary;
        }
        
        public Collision CollideWith(ICollidingShell collidingShell)
        {
            return collidingShell.CollideAgainstBox(_shell);
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