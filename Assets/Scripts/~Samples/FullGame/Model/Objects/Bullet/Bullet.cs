﻿using System;
using System.Linq;
using GameLibrary.Math;


namespace GameLibrary.Sample
{
    public class Bullet : IBullet
    {
        private readonly int _damage;
        private readonly IPhysicalObject _physicalObject;
        private readonly IBulletView _view;
        private readonly ICollisionsWorld<ICharacter> _charactersToHit;

        public Bullet(int damage, IPhysicalObject physicalObject, IBulletView view, ICollisionsWorld<ICharacter> charactersToHit)
        {
            _damage = damage;
            _physicalObject = physicalObject;
            _view = view;
            _charactersToHit = charactersToHit;
        }

        public bool IsAlive { get; private set; } = true;

        public void ExecuteTick(long elapsedMilliseconds)
        {
            if (!IsAlive)
                throw new Exception();

            var interactedCharacters = _charactersToHit.InteractionsWith(_physicalObject);
            if (interactedCharacters.Length == 0) 
                return;
            
            ICharacter character = interactedCharacters.First().First.Concrete;
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
            _view.Destroy();
        }
    }
}