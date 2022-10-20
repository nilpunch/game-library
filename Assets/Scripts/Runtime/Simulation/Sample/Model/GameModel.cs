namespace GameLibrary
{
    public class GameModel : IModel<GameSnapshot>, ICharacterMovement, IGameStage
    {
        public void ExecuteTick(long elapsedMilliseconds)
        {
            throw new System.NotImplementedException();
        }

        public GameSnapshot MakeSnapshot()
        {
            throw new System.NotImplementedException();
        }

        public void RestoreSnapshot(GameSnapshot snapshot)
        {
            throw new System.NotImplementedException();
        }

        public void Move(int characterId, Vector3 moveInput)
        {
            throw new System.NotImplementedException();
        }

        public void StartGame()
        {
            throw new System.NotImplementedException();
        }
    }
}