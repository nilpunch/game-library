using System;

namespace PhysicsSample
{
    public class GameSample
    {
        private readonly IGameLoop _gameLoop;

        public GameSample()
        {
            _gameLoop = new GameLoop();
            
            // Add physics world
            var physicWorld = new PhysicWorld();
            _gameLoop.Add(new ConstantExecutionTimeStep(physicWorld, 20));

            // Add some characters
            var charactersAssociations = new PhysicWorldAssociations<ICharacter>();
            var characterFactory = new CharactersFactory(_gameLoop, physicWorld, charactersAssociations);
            _gameLoop.Add(characterFactory.Create(health: 10));
            
            // Add player that shoots weapon
            var bulletsAssiciations = new PhysicWorldAssociations<IBullet>();
            _gameLoop.Add(new Player(new Weapon(bulletsDamage: 1, bulletsLiveTime: 100, new BulletFactory(_gameLoop, physicWorld, bulletsAssiciations, charactersAssociations))));
        }
        
        public void ExecuteFrame(long time)
        {
            _gameLoop.ExecuteFrame(time);
        }
    }
}