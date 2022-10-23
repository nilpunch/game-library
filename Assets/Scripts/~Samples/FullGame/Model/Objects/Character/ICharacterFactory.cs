namespace GameLibrary.Sample.FullGame
{
    public interface ICharacterFactory
    {
        ICharacter Create(int health, IWeapon weapon);
    }
}