namespace GameLibrary.Sample.MV
{
	public class CharacterView : ICharacterView, IVisualisation
	{
		private int _healthToRender;
		
		public void ShowHealth(int amount)
		{
			_healthToRender = amount;
		}

		public void Render(long elapsedMilliseconds)
		{
			// Call some MeshRenderer and other high- to low-level rendering things
		}
	}
}