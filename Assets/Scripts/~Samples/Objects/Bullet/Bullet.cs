using System;
using System.Linq;


namespace GameLibrary
{
    public class Bullet : IBullet
    {
        private readonly int _damage;
        private readonly long _liveTime;
        private readonly IPhysicalObject _physicalObject;
        private readonly ICollisionsWorld<ICharacter> _charactersToHit;

        private long _creationTime = -1;

        public Bullet(int damage, long liveTime, IPhysicalObject physicalObject, ICollisionsWorld<ICharacter> charactersToHit)
        {
            _damage = damage;
            _liveTime = liveTime;
            _physicalObject = physicalObject;
            _charactersToHit = charactersToHit;
        }

        public bool IsAlive { get; private set; }

        public void ExecuteTick(long elapsedMilliseconds)
        {
            if (!IsAlive)
                throw new Exception();

            if (_creationTime == -1)
                _creationTime = elapsedMilliseconds;

            if (elapsedMilliseconds > _creationTime + _liveTime)
            {
                DestroySelf();
                return;
            }

            var interactedCharacters = _charactersToHit.InteractionsWith(_physicalObject);

            if (interactedCharacters.Length == 0) 
                return;
            
            var character = interactedCharacters.First().Object;
            if (character.IsAlive)
                character.TakeDamage(_damage);

            DestroySelf();
        }

        public void Throw(Vector3 velocity)
        {
            _physicalObject.AddVelocityChange(velocity);
        }

        private void DestroySelf()
        {
            IsAlive = false;
            _physicalObject.Destroy();
        }
    }
}