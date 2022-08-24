using System;
using UnityEngine;

namespace PhysicsSample
{
    public class Bullet : IBullet
    {
        private readonly int _damage;
        private readonly long _liveTime;
        private readonly IPhysicalObject _physicalObject;

        private long _creationTime = -1;
        
        public Bullet(int damage, long liveTime, IPhysicalObject physicalObject)
        {
            _damage = damage;
            _liveTime = liveTime;
            _physicalObject = physicalObject;
            
            CanExecuteFrame = true;
            CanDamage = true;
        }

        public bool CanExecuteFrame { get; private set; }
        
        public bool CanDamage { get; private set; }

        public void ExecuteFrame(long time)
        {
            if (!CanExecuteFrame)
                throw new Exception();

            if (_creationTime == -1)
                _creationTime = time;

            bool livetimeExpired = time > _creationTime + _liveTime;
            
            if (!CanDamage || livetimeExpired)
                DestroySelf();
        }

        public void Throw(Vector3 velocity)
        {
            _physicalObject.AddVelocityChange(velocity);
        }
        
        public void Damage(ICharacter character)
        {
            if (!CanDamage)
                throw new Exception();
            
            character.Damage(_damage);

            CanDamage = false;
        }

        private void DestroySelf()
        {
            CanExecuteFrame = false;
        }
    }
}