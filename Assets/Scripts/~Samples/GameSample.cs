namespace GameLibrary
{
    public class GameSample
    {
        private readonly ISimulationTick _gameLoop;

        public GameSample()
        {
            var physicWorld = new PhysicWorld();

            var physicalCharacters = new PhysicWorldObjects<ICharacter>();
            var physicalBullets = new PhysicWorldObjects<IBullet>();

            var bulletCharacterInteractions = new InteractionsFilter<IBullet, ICharacter>(physicWorld, 
                physicalBullets,
                physicalCharacters,
                new BulletCharacterInteraction());

            var bulletsLoop = new GameObjectsGroup();
            var playersLoop = new GameObjectsGroup(new IGameObject[]
            {
                new Player(new ProjectileWeapon(1, 100, new BulletFactory(bulletsLoop, physicWorld, physicalBullets))),
                new Player(new HitScanWeapon(1, physicWorld, physicalCharacters)),
            });
            var charactersLoop = new GameObjectsGroup(new IGameObject[]
            {
                new CharactersFactory(physicWorld, physicalCharacters).Create(10),
            });

            var mainGameObjectsLoop = new SimulationTickGroup(new ISimulationTick[]
            {
                bulletsLoop,
                playersLoop,
                charactersLoop,
            });

            var mainPhysicsLoop = new ConstantExecutionTimeStep(new SimulationTickGroup(new ISimulationTick[]
            {
                physicWorld,
                physicalCharacters,
                physicalBullets,
                bulletCharacterInteractions
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