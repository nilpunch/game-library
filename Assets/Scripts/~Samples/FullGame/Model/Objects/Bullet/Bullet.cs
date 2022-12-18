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
        private readonly IRaycastShooter<ICharacter> _characterRaycasts;

        public Bullet(int damage, IRigidbody rigidbody, IBulletView view, IRaycastShooter<ICharacter> characterRaycasts)
        {
            _damage = damage;
            _rigidbody = rigidbody;
            _view = view;
            _characterRaycasts = characterRaycasts;
        }

        public bool IsAlive { get; private set; } = true;

        public void Step(long elapsedMilliseconds)
        {
            if (!IsAlive)
                throw new Exception();

            var characterHit = _characterRaycasts.Raycast(_rigidbody.Position, _rigidbody.Velocity);
            if (!characterHit.Occure)
                return;

            ICharacter character = characterHit.HitResult;
            if (character.IsAlive)
                character.TakeDamage(_damage);

            DestroySelf();
        }

        public void Throw(SoftVector3 velocity)
        {
            _rigidbody.Velocity = velocity;
        }

        private void DestroySelf()
        {
            IsAlive = false;
            // _rigidbody.Destroy();
            _view.Destroy();
        }
    }
}
