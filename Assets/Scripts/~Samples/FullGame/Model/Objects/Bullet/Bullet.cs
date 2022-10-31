using System;
using System.Linq;
using GameLibrary.Mathematics;
using GameLibrary.Physics;


namespace GameLibrary.Sample
{
    public class Bullet : IBullet, IGameObject
    {
        private readonly int _damage;
        private readonly IRigidbody _rigidbody;
        private readonly IBulletView _view;
        private readonly ICollisionsWorld<ICharacter> _charactersToHit;

        public Bullet(int damage, IRigidbody rigidbody, IBulletView view, ICollisionsWorld<ICharacter> charactersToHit)
        {
            _damage = damage;
            _rigidbody = rigidbody;
            _view = view;
            _charactersToHit = charactersToHit;
        }

        public bool IsAlive { get; private set; } = true;

        public void Step(long elapsedMilliseconds)
        {
            if (!IsAlive)
                throw new Exception();

            var interactedCharacters = _charactersToHit.CollisionsWith(_rigidbody);
            if (interactedCharacters.Length == 0) 
                return;
            
            ICharacter character = interactedCharacters.First().First.Concrete;
            if (character.IsAlive)
                character.TakeDamage(_damage);

            DestroySelf();
        }

        public void Throw(float3 velocity)
        {
            _rigidbody.Velocity = velocity;
        }

        private void DestroySelf()
        {
            IsAlive = false;
            _rigidbody.Destroy();
            _view.Destroy();
        }
    }
}