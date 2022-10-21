namespace GameLibrary.Sample
{
    public class Model : ISimulationModel<ModelSnapshot>, IVisualisation,
        ICharacterMovement
    {
        private readonly ISimulationTick _gameLoop;
        private readonly IVisualisation _visualisation;

        public Model()
        {
            var physicWorld = new PhysicWorld();

            var charactersPhysicWorld = new SubPhysicWorld<ICharacter>(physicWorld);
            var bulletsPhysicWorld = new SubPhysicWorld<IBullet>(physicWorld);
            
            var bulletsGroup = new GameObjectsGroup();
            var characterFactory = new CharacterFactory(charactersPhysicWorld);

            var charactersGroup = new GameObjectsGroup(new IGameObject[]
            {
                characterFactory.Create(10, new ProjectileWeapon(1, 
                    new BulletFactory(bulletsGroup, bulletsPhysicWorld, charactersPhysicWorld))),
                characterFactory.Create(10, new HitScanWeapon(1, charactersPhysicWorld)),
            });
            
            _gameLoop = new SimulationTickGroup(new ISimulationTick[]
            {
                new SimulationTickGroup(new ISimulationTick[]
                {
                    new CleanupGraveyardTick(physicWorld),
                    new CleanupGraveyardTick(charactersPhysicWorld),
                    new CleanupGraveyardTick(bulletsPhysicWorld),
                    new CleanupGraveyardTick(charactersGroup)
                }),
                
                physicWorld,
                new SimulationTickGroup(new ISimulationTick[]
                {
                    bulletsGroup,
                    charactersGroup,
                })
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

        public void Render(long elapsedMilliseconds)
        {
            _visualisation.Render(elapsedMilliseconds);
        }

        public void Move(long characterId, Vector3 input)
        {
            throw new System.NotImplementedException();
        }
    }
}