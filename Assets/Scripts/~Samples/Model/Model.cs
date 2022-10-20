namespace GameLibrary.Sample
{
    public class Model : ISimulationModel<ModelSnapshot>, IVisualisation
    {
        private readonly ISimulationTick _gameLoop;
        private readonly IVisualisation _visualisation;

        public Model()
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
            
            var characterFactory = new CharacterFactory(charactersPhysicWorld);
            var charactersLoop = new GameObjectsGroup(new IGameObject[]
            {
                characterFactory.Create(10, new ProjectileWeapon(1, new BulletFactory(bulletsLoop, bulletsPhysicWorld, charactersPhysicWorld))),
                characterFactory.Create(10, new HitScanWeapon(1, charactersPhysicWorld)),
            });

            var mainGameObjectsLoop = new SimulationTickGroup(new ISimulationTick[]
            {
                cleanDeadObjects,
                bulletsLoop,
                charactersLoop,
            });

            _gameLoop = new SimulationTickGroup(new ISimulationTick[]
            {
                physicWorld,
                mainGameObjectsLoop,
            });
        }

        public void ExecuteTick(long elapsedMilliseconds)
        {
            _gameLoop.ExecuteTick(elapsedMilliseconds);
        }

        public ModelSnapshot MakeSnapshot()
        {
            throw new System.NotImplementedException();
        }

        public void RestoreSnapshot(ModelSnapshot snapshot)
        {
            throw new System.NotImplementedException();
        }

        public void Render(long elapsedMilliseconds)
        {
            _visualisation.Render(elapsedMilliseconds);
        }
    }
}