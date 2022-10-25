using GameLibrary.Lifetime;
using GameLibrary.Rendering;

namespace GameLibrary.Sample
{
    public class Model : ISimulationModel<ModelSnapshot>
    {
        private readonly ISimulationTick _gameLoop;

        public Model(IViewLibrary viewLibrary)
        {
            // Views
            var characterViewFactory = viewLibrary.CharacterViewFactory();
            var bulletViewFactory = viewLibrary.BulletViewFactory();
            
            // Physics
            var physicWorld = new PhysicWorld();
            var charactersPhysicWorld = new SubPhysicWorld<ICharacter>(physicWorld);
            
            // Game Objects
            var bulletsGameObjects = new GameObjectsGroup();
            
            var characterFactory = new CharacterFactory(charactersPhysicWorld, characterViewFactory);
            var charactersGameObjects = new GameObjectsGroup(new IGameObject[]
            {
                characterFactory.Create(10, new ProjectileWeapon(1, 
                    new BulletFactory(bulletsGameObjects, physicWorld, charactersPhysicWorld, bulletViewFactory))),
                characterFactory.Create(10, new HitScanWeapon(1, charactersPhysicWorld)),
            });

            // Cleanup all dead objects
            var cleanup = new SimulationTickGroup(new ISimulationTick[]
            {
                new CleanupDeadTick(physicWorld),
                new CleanupDeadTick(charactersPhysicWorld),
                new CleanupDeadTick(charactersGameObjects),
            });
            
            _gameLoop = new SimulationTickGroup(new ISimulationTick[]
            {
                cleanup,
                physicWorld,
                bulletsGameObjects,
                charactersGameObjects
            });
        }

        public void ExecuteTick(long elapsedMilliseconds)
        {
            _gameLoop.ExecuteTick(elapsedMilliseconds);
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