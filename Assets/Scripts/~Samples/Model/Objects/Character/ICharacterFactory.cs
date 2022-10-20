namespace GameLibrary.Sample
{
    public interface ICharacterFactory
    {
        ICharacter Create(int health, IWeapon weapon);
    }
}