namespace GameLibrary
{
    public class MoveCharacterCommand : ICommand<ICharacterMovement>
    {
        public void Execute(ICharacterMovement model)
        {
            model.Move(1, Vector3.Forward);
        }
    }
}