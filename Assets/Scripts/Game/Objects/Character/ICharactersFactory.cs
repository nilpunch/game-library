namespace PhysicsSample
{
    public interface ICharactersFactory
    {
        ICharacter Create(int health);
    }
}