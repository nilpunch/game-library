namespace GameLibrary.Rendering
{
	public interface IText : IAlive
	{
		void SetText(string text);

		void Destroy();
	}
}