using GameLibrary.Lifetime;
using GameLibrary.Physics;

namespace GameLibrary.Sample
{
    public class Model : ISimulationModel<ModelSnapshot>
    {
        private readonly ISimulationObject _gameLoop;

        public Model(IViewLibrary viewLibrary)
        {
            // Views
            var characterViewFactory = viewLibrary.CharacterViewFactory();
            var bulletViewFactory = viewLibrary.BulletViewFactory();

            // Physics
            var physicWorld = new PhysicWorld<IRigidbody<IMatrixCollider>, IMatrixCollider>(null, null);
            var charactersPhysicWorld = new SubPhysicWorld<IRigidbody<IMatrixCollider>, IMatrixCollider, ICharacter>(physicWorld);

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
            var cleanup = new SimulationObjectGroup(new ISimulationObject[]
            {
                // new CleanupDeadObjects(physicWorld),
                // new CleanupDeadObjects(charactersPhysicWorld),
                new CleanupDeadObjects(charactersGameObjects),
            });

            _gameLoop = new SimulationObjectGroup(new ISimulationObject[]
            {
                cleanup,
                // physicWorld,
                bulletsGameObjects,
                charactersGameObjects
            });
        }

        public void Step(long elapsedMilliseconds)
        {
            _gameLoop.Step(elapsedMilliseconds);
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
