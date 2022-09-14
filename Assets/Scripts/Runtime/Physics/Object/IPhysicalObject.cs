namespace GameLibrary
{
    public interface IPhysicalObject
    {
        ICollidingShell Shell { get; }

        void AddVelocityChange(Vector3 velocity);

        bool IsExist { get; }

        void Destroy();
    }
}