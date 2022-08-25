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

            // Link physical representation to game objects
            var charactersWorld = new PhysicWorldAssociations<ICharacter>(physicWorld);
            var bulletsWorld = new PhysicWorldAssociations<IBullet>(physicWorld);

            physicWorld.AddInteraction(
                new PhysicalObjectsInteraction<IBullet, ICharacter>(bulletsWorld, charactersWorld, new BulletEnemyInteraction()));
            
            // Add some characters
            _gameLoop.Add(new CharactersFactory(_gameLoop, charactersWorld).Create(health: 10));
            
            // Add player that shoots weapon
            _gameLoop.Add(new Player(new Weapon(1, 100, new BulletFactory(_gameLoop, bulletsWorld))));
            
            _actualization = new ActualizationGroup(new IActualization[]
            {
                _gameLoop, bulletsWorld, charactersWorld
            });
        }
        
        public void ExecuteFrame(long time)
        {
            _actualization.RemoveAllInactual();
            _gameLoop.ExecuteFrame(time);
        }
    }
}