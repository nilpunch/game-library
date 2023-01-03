using GameLibrary.Lifetime;
using GameLibrary.Physics;
using GameLibrary.Physics.SupportMapping;
using GameLibrary.Physics.Raycast;

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
            var solidWallsRaycast = new RaycastWorld();
            var charactersRaycast = new ConcreteRaycastSubWorld<ICharacter>(solidWallsRaycast);

            var smCollidersWorld = new SMCollidersWorld<IRigidbody>(40, 40);
            var analyticCollidersWorld = new AnalyticCollidersWorld<IRigidbody>();

            var mergedCollisions = new MergedCollisions<IRigidbody>(new ICollisions<IRigidbody>[]
            {
                smCollidersWorld, analyticCollidersWorld
            });

            var physicSimulation = new PhysicSimulation<IRigidbody>(mergedCollisions, new RigidbodyCollisionsSolver());

            // Game Objects
            var bulletsGameObjects = new GameObjectsGroup();

            var characterFactory = new CharacterFactory(null, characterViewFactory);
            var charactersGameObjects = new GameObjectsGroup(new IGameObject[]
            {
                characterFactory.Create(10, new ProjectileWeapon(1, new BulletFactory(bulletsGameObjects, charactersRaycast, bulletViewFactory))),
                characterFactory.Create(10, new HitScanWeapon(1, charactersRaycast)),
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
