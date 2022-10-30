namespace GameLibrary.Physics
{
    public class CollisionsLibrary : ICollisionsLibrary
    {
        public Collision BoxAgainstBox(IBoxShell first, IBoxShell second)
        {
            throw new System.NotImplementedException();
        }

        public Collision SphereAgainstBox(ISphereShell first, IBoxShell second)
        {
            throw new System.NotImplementedException();
        }

        public Collision SphereAgainstSphere(ISphereShell first, ISphereShell second)
        {
            throw new System.NotImplementedException();
        }

        public Collision ConvexAgainstBox(IConvexShell first, IBoxShell second)
        {
            throw new System.NotImplementedException();
        }

        public Collision ConvexAgainstSphere(IConvexShell first, ISphereShell second)
        {
            throw new System.NotImplementedException();
        }

        public Collision ConvexAgainstConvex(IConvexShell first, IConvexShell second)
        {
            throw new System.NotImplementedException();
        }
    }
}