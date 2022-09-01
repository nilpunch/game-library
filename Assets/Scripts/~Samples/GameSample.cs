namespace PhysicsSample
{
    public class GameSample
    {
        private readonly IFrameExecution _gameLoop;

        public GameSample()
        {
            var characterLinks = new PhysicWorldLinks<ICharacter>();
            var bulletLinks = new PhysicWorldLinks<IBullet>();

            var physicWorld = new PhysicWorld(new IPhysicalObjectsInteraction[]
            {
                new PhysicalObjectsInteraction<IBullet, ICharacter>(bulletLinks, characterLinks, new BulletEnemyInteraction())
            });
            
            var gameObjectsLoop = new GameObjectsLoop(new IGameObject[]
            {
                new CharactersFactory(physicWorld, characterLinks).Create(10),
                new Player(new Weapon(1, 100, new BulletFactory(physicWorld, bulletLinks))),
            });
            
            _gameLoop = new GameLoop(new IFrameExecution[]
            {
                new ConstantExecutionTimeStep(physicWorld, 20),
                gameObjectsLoop,
                characterLinks,
                bulletLinks,
            });
        }
        
        public void ExecuteFrame(long time)
        {
            _gameLoop.ExecuteFrame(time);
        }
    }
}