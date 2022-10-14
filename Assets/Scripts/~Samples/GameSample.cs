namespace GameLibrary
{
    public class GameSample
    {
        private readonly ISimulationTick _gameLoop;

        public GameSample()
        {
            var physicWorld = new PhysicWorld();

            var charactersPhysicWorld = new PhysicSubWorld<ICharacter>(physicWorld);
            var bulletsPhysicWorld = new PhysicSubWorld<IBullet>(physicWorld);

            var bulletsLoop = new GameObjectsGroup();
            
            var playersLoop = new GameObjectsGroup(new IGameObject[]
            {
                new Player(new ProjectileWeapon(1, 100, new BulletFactory(bulletsLoop, bulletsPhysicWorld, charactersPhysicWorld))),
                new Player(new HitScanWeapon(1, charactersPhysicWorld)),
            });
            
            var charactersLoop = new GameObjectsGroup(new IGameObject[]
            {
                new CharactersFactory(charactersPhysicWorld).Create(10),
            });

            var mainGameObjectsLoop = new SimulationTickGroup(new ISimulationTick[]
            {
                bulletsLoop,
                playersLoop,
                charactersLoop,
            });

            var mainPhysicsLoop = new ConstantExecutionTimeStep(new SimulationTickGroup(new ISimulationTick[]
            {
                physicWorld
            }), 20);

            _gameLoop = new SimulationTickGroup(new ISimulationTick[]
            {
                mainPhysicsLoop,
                mainGameObjectsLoop,
            });
        }

        public void ExecuteFrame(long time)
        {
            _gameLoop.ExecuteTick(time);
        }
    }
}