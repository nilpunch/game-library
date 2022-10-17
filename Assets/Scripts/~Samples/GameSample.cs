namespace GameLibrary
{
    public class GameSample
    {
        private readonly ISimulationTick _gameLoop;

        public GameSample()
        {
            var physicWorld = new PhysicWorld();

            var charactersPhysicWorld = new SubPhysicWorld<ICharacter>(physicWorld);
            var bulletsPhysicWorld = new SubPhysicWorld<IBullet>(physicWorld);

            // This must go in it's own separate contract, without ISimulationTick use
            var cleanDeadObjects = new SimulationTickGroup(new ISimulationTick[]
            {
                charactersPhysicWorld,
                bulletsPhysicWorld,
            });

            // Run bullets in outer loop. It's can be done in local composition too.
            var bulletsLoop = new GameObjectsGroup();
            
            var playersLoop = new GameObjectsGroup(new IGameObject[]
            {
                new Player(new ProjectileWeapon(1, new BulletFactory(bulletsLoop, bulletsPhysicWorld, charactersPhysicWorld))),
                new Player(new HitScanWeapon(1, charactersPhysicWorld)),
            });
            
            var charactersLoop = new GameObjectsGroup(new IGameObject[]
            {
                new CharactersFactory(charactersPhysicWorld).Create(10),
            });

            var mainGameObjectsLoop = new SimulationTickGroup(new ISimulationTick[]
            {
                cleanDeadObjects,
                bulletsLoop,
                playersLoop,
                charactersLoop,
            });

            // Technically, application should run whole simulation with fixed time step,
            // but this example contains proof that game loops can be separated in terms of time step.
            var mainPhysicsLoop = new ConstantExecutionTimeStep(physicWorld, 20);

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