namespace PhysicsSample
{
    public class GameSample
    {
        private readonly IFrameExecution _gameLoop;

        public GameSample()
        {
            var physicWorld = new PhysicWorld();
            
            var characterLinks = new PhysicWorldLinks<ICharacter>();
            var bulletLinks = new PhysicWorldLinks<IBullet>();

            var gameObjectsLoop = new GameObjectsGroup(new IGameObject[]
            {
                new CharactersFactory(physicWorld, characterLinks).Create(10),
                new Player(new Weapon(1, 100, new BulletFactory(physicWorld, bulletLinks))),
            });

            var physicsLoop = new ConstantExecutionTimeStep(new FrameExecutionGroup(new IFrameExecution[]
            {
                physicWorld,
                characterLinks,
                bulletLinks,
                new PhysicalObjectsInteraction<IBullet, ICharacter>(physicWorld, bulletLinks, characterLinks, new BulletCharacterInteraction())
            }), 20);
            
            _gameLoop = new FrameExecutionGroup(new IFrameExecution[]
            {
                physicsLoop,
                gameObjectsLoop,
            });
        }
        
        public void ExecuteFrame(long time)
        {
            _gameLoop.ExecuteFrame(time);
        }
    }
}