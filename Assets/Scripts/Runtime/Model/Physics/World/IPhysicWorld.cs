﻿namespace GameLibrary.Physics
{
    public interface IPhysicWorld : ICollisionsWorld
    {
        void Add(IRigidbody rigidbody);
        void Remove(IRigidbody rigidbody);
    }
}