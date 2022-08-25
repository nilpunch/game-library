namespace PhysicsSample
{
    public interface ICollisionsLibrary
    {
        Collision BoxAgainstBox(IBoxShell first, IBoxShell second);
        
        Collision SphereAgainstBox(ISphereShell first, IBoxShell second);
        Collision SphereAgainstSphere(ISphereShell first, ISphereShell second);
        
        Collision ConvexAgainstBox(IConvexShell first, IBoxShell second);
        Collision ConvexAgainstSphere(IConvexShell first, ISphereShell second);
        Collision ConvexAgainstConvex(IConvexShell first, IConvexShell second);
    }
}