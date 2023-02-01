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
            var analyticCollidersWorld = new DoubleCastCollidersWorld<IRigidbody>();

            var mergedCollisions = new MergedCollisions<IRigidbody>(new ICollisions<IRigidbody>[]
            {
                smCollidersWorld, analyticCollidersWorld
            });

            var physicSimulation = new PhysicSimulation<IRigidbody>(mergedCollisions, new RigidbodyCollisionsSolver());

            // Game Objects
            var bulletsGameObjects = new SelfCleaningGameObjectsGroup();

            var soldierCharacterFactory =
                new CharacterFactory(20,
                    new ProjectileWeaponFactory(1,
                        new BulletFactory(bulletsGameObjects, charactersRaycast, bulletViewFactory)),
                charactersRaycast, characterViewFactory);

            var sniperCharacterFactory = new CharacterFactory(10,
                new HitScanWeaponFactory(1, charactersRaycast),
                charactersRaycast, characterViewFactory);

            var charactersGameObjects = new SelfCleaningGameObjectsGroup(new IGameObject[]
            {
                soldierCharacterFactory.Create(),
                soldierCharacterFactory.Create(),
                sniperCharacterFactory.Create(),
            });

            _gameLoop = new SimulationObjectGroup(new ISimulationObject[]
            {
                new SimulatePhysics(physicSimulation),
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
