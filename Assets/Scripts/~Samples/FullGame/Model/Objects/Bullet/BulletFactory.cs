﻿using GameLibrary.Mathematics;
using GameLibrary.Physics;
using GameLibrary.Physics.Raycast;

namespace GameLibrary.Sample
{
    public class BulletFactory : IBulletFactory
    {
        private readonly IGameObjectsGroup _bulletsLoop;
        private readonly IRaycastShooter<ICharacter> _charactersRaycast;
        private readonly IBulletViewFactory _bulletViewFactory;

        public BulletFactory(IGameObjectsGroup bulletsLoop, IRaycastShooter<ICharacter> charactersRaycast, IBulletViewFactory bulletViewFactory)
        {
            _bulletsLoop = bulletsLoop;
            _charactersRaycast = charactersRaycast;
            _bulletViewFactory = bulletViewFactory;
        }

        public IBullet Create(int damage)
        {
            var rigidbody = new Rigidbody();
            var bullet = new Bullet(damage, rigidbody, _bulletViewFactory.Create(), _charactersRaycast);

            _bulletsLoop.Add(bullet);

            return bullet;
        }
    }
}
