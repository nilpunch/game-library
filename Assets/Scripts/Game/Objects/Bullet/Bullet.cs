using System;
using UnityEngine;

namespace PhysicsSample
{
    public class Bullet : IBullet
    {
        private readonly int _damage;
        private readonly long _liveTime;
        private readonly IPhysicalObject _physicalObject;
        private readonly IPhysicWorld _physicWorld;
        private readonly IPhysicWorldAssociations<IBullet> _bulletsAssociations;
        private readonly IReadOnlyPhysicWorldAssociations<ICharacter> _charactersAssociations;

        private long _creationTime = -1;
        
        public Bullet(int damage, long liveTime, IPhysicalObject physicalObject, IPhysicWorld physicWorld,
            IPhysicWorldAssociations<IBullet> bulletsAssociations, IReadOnlyPhysicWorldAssociations<ICharacter> charactersAssociations)
        {
            _damage = damage;
            _liveTime = liveTime;
            _physicalObject = physicalObject;
            _physicWorld = physicWorld;
            _bulletsAssociations = bulletsAssociations;
            _charactersAssociations = charactersAssociations;
            
            CanExecuteFrame = true;
        }

        public bool CanExecuteFrame { get; private set; }

        public void ExecuteFrame(long time)
        {
            if (!CanExecuteFrame)
                throw new Exception();

            if (_creationTime == -1)
                _creationTime = time;

            if (time > _creationTime + _liveTime)
            {
                DestroySelf();
                return;
            }
            
            Collision collision = _physicWorld.CalculateCollision(_physicalObject, "Character");
            
            if (collision.Occure)
            {
                if (_charactersAssociations.HasAssociatedObject(collision.CollidedObject))
                {
                    ICharacter character = _charactersAssociations.GetAssociatedObject(collision.CollidedObject);

                    if (character.IsAlive)
                    {
                        character.Damage(_damage);

                        DestroySelf();
                    }
                }
            }
        }

        public void Throw(Vector3 velocity)
        {
            _physicalObject.AddVelocity(velocity);
        }

        private void DestroySelf()
        {
            _physicWorld.Remove(_physicalObject);
            _bulletsAssociations.Remove(_physicalObject);
            CanExecuteFrame = false;
        }
    }
}