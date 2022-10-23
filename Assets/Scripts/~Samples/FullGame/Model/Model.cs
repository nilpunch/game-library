namespace GameLibrary.Sample.FullGame
{
    public class Model : ISimulationModel<ModelSnapshot>, IVisualisation
    {
        private readonly ISimulationTick _gameLoop;
        private readonly IVisualisation _visualisation;

        public Model()
        {
            // All view's to render
            var liveVisualisations = new AliveVisualisationGroup();

            // Physics
            var physicWorld = new PhysicWorld();
            var charactersPhysicWorld = new SubPhysicWorld<ICharacter>(physicWorld);
            
            // Game Objects
            var bulletsGameObjects = new GameObjectsGroup();
            
            var characterFactory = new CharacterFactory(charactersPhysicWorld, new CharacterViewFactory(liveVisualisations));
            var charactersGameObjects = new GameObjectsGroup(new IGameObject[]
            {
                characterFactory.Create(10, new ProjectileWeapon(1, 
                    new BulletFactory(bulletsGameObjects, physicWorld, charactersPhysicWorld))),
                characterFactory.Create(10, new HitScanWeapon(1, charactersPhysicWorld)),
            });

            // Cleanup all dead objects
            var cleanup = new SimulationTickGroup(new ISimulationTick[]
            {
                new CleanupGraveyardTick(physicWorld),
                new CleanupGraveyardTick(charactersPhysicWorld),
                new CleanupGraveyardTick(charactersGameObjects),
                new CleanupGraveyardTick(liveVisualisations)
            });
            
            _gameLoop = new SimulationTickGroup(new ISimulationTick[]
            {
                cleanup,
                physicWorld,
                bulletsGameObjects,
                charactersGameObjects
            });

            _visualisation = liveVisualisations;
        }

        public void ExecuteTick(long elapsedMilliseconds)
        {
            _gameLoop.ExecuteTick(elapsedMilliseconds);
        }

        public void Render(long elapsedMilliseconds)
        {
            _visualisation.Render(elapsedMilliseconds);
        }

        public ModelSnapshot TakeSnapshot()
        {
            throw new System.NotImplementedException();
        }

        public void ApplySnapshot(ModelSnapshot snapshot)
        {
            throw new System.NotImplementedException();
        }
    }
}