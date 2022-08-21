namespace PhysicsSample
{
    public class CollidingShellGroup : ICollidingShell
    {
        private readonly ICollidingShell[] _collidingShells;

        public CollidingShellGroup(ICollidingShell[] collidingShells)
        {
            _collidingShells = collidingShells;
        }
        
        public Collision Collide(ICollidingShell collidingShell)
        {
            Collision collision = new Collision();
            
            foreach (var shell in _collidingShells) 
                collision = collision.Merge(shell.Collide(collidingShell));

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