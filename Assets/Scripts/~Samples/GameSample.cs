namespace GameLibrary
{
    public class GameSample
    {
        private readonly IFrameExecution _gameLoop;

        public GameSample()
        {
            var physicWorld = new PhysicWorld();

            var physicalCharacters = new PhysicWorldObjects<ICharacter>();
            var physicalBullets = new PhysicWorldObjects<IBullet>();

            var bulletCharacterInteractions = new PhysicalInteractions<IBullet, ICharacter>(physicWorld, 
                physicalBullets,
                physicalCharacters,
                new BulletCharacterInteraction());
            
            var mainGameObjectsLoop = new GameObjectsGroup();
            mainGameObjectsLoop.Add(new CharactersFactory(physicWorld, physicalCharacters).Create(10));
            mainGameObjectsLoop.Add(new Player(new Weapon(1, 100, new BulletFactory(physicWorld, physicalBullets))));

            var mainPhysicsLoop = new ConstantExecutionTimeStep(new FrameExecutionGroup(new IFrameExecution[]
            {
                physicWorld,
                physicalCharacters,
                physicalBullets,
                bulletCharacterInteractions
            }), 20);

            _gameLoop = new FrameExecutionGroup(new IFrameExecution[]
            {
                mainPhysicsLoop,
                mainGameObjectsLoop,
            });
        }

        public void ExecuteFrame(long time)
        {
            _gameLoop.ExecuteFrame(time);
        }
    }
}