namespace PhysicsSample
{
    public class GameSample
    {
        private readonly IActualization _actualization;
        private readonly IGameLoop _gameLoop;

        public GameSample()
        {
            _gameLoop = new GameLoop();
            
            // Add physics world
            var physicWorld = new PhysicWorld();
            _gameLoop.Add(new ConstantExecutionTimeStep(physicWorld, 20));

            // Link concrete objects to its physical representation
            var charactersWrold = new PhysicWorldObjects<ICharacter>(physicWorld);
            var bulletsWrold = new PhysicWorldObjects<IBullet>(physicWorld);

            physicWorld.AddInteraction(
                new PhysicalObjectsInteraction<IBullet, ICharacter>(bulletsWrold, charactersWrold, new BulletEnemyInteraction()));
            
            // Add some characters
            _gameLoop.Add(new CharactersFactory(_gameLoop, charactersWrold).Create(health: 10));
            
            // Add player that shoots weapon
            _gameLoop.Add(new Player(new Weapon(bulletsDamage: 1, bulletsLiveTime: 100, new BulletFactory(_gameLoop, bulletsWrold))));
            
            _actualization = new ActualizationGroup(new IActualization[]
            {
                _gameLoop, bulletsWrold, charactersWrold
            });
        }
        
        public void ExecuteFrame(long time)
        {
            _actualization.RemoveAllInactual();
            _gameLoop.ExecuteFrame(time);
        }
    }
}