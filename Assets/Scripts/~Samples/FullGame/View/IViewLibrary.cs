namespace GameLibrary.Sample
{
	public interface IViewLibrary
	{
		ICharacterViewFactory CharacterViewFactory();
		IBulletViewFactory BulletViewFactory();
	}
}