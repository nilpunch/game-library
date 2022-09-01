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
            
            CanDamage = true;
        }

        public bool IsActual => CanDamage;
        
        public bool CanDamage { get; private set; }

        public void ExecuteFrame(long elapsedTime)
        {
            if (!IsActual)
                throw new Exception();

            if (_creationTime == -1)
                _creationTime = elapsedTime;

            if (elapsedTime > _creationTime + _liveTime)
                Destroy();
        }

        public void Throw(Vector3 velocity)
        {
            _physicalObject.AddVelocityChange(velocity);
        }
        
        public void Damage(ICharacter character)
        {
            if (!CanDamage)
                throw new Exception();
            
            character.TakeDamage(_damage);

            Destroy();
        }

        private void Destroy()
        {
            CanDamage = false;
            _physicalObject.Destroy();
        }
    }
}