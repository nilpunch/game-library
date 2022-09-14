namespace GameLibrary
{
    public interface ICharactersFactory
    {
        ICharacter Create(int health);
    }
}