using System;

namespace PhysicsSample
{
    public class GameSample
    {
        private readonly IActualization _actualization;
        private readonly IGameLoop _gameLoop;

        public GameSample()
        {
            var gameLoop = new GameLoop();
            
            // Add physics world
            var physicWorld = new PhysicWorld();
            gameLoop.Add(new ConstantExecutionTimeStep(physicWorld, 20));

            var charactersAssociations = new CollideObjects<ICharacter>(physicWorld);
            var bulletsAssiciations = new CollideObjects<IBullet>(physicWorld);

            physicWorld.AddInteraction(
                new PhysicalObjectsInteraction<IBullet, ICharacter>(bulletsAssiciations, charactersAssociations, new BulletEnemyInteraction()));
            
            // Add some characters
            gameLoop.Add(new CharactersFactory(gameLoop, charactersAssociations).Create(health: 10));
            
            // Add player that shoots weapon
            gameLoop.Add(new Player(new Weapon(bulletsDamage: 1, bulletsLiveTime: 100, new BulletFactory(gameLoop, bulletsAssiciations))));
            
            _gameLoop = gameLoop;
            _actualization = new ActualizationGroup(new IActualization[]
                { gameLoop, bulletsAssiciations, charactersAssociations });
        }
        
        public void ExecuteFrame(long time)
        {
            _actualization.RemoveAllInactual();
            _gameLoop.ExecuteFrame(time);
        }
    }
}