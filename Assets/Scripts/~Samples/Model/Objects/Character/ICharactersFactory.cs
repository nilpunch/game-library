namespace GameLibrary.Sample
{
    public interface ICharactersFactory
    {
        ICharacter Create(int health);
    }
}