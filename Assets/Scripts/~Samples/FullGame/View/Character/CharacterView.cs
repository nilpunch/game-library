using GameLibrary.Rendering;

namespace GameLibrary.Sample
{
	public class CharacterView : ICharacterView
	{
		private readonly IText _text;

		public CharacterView(IText text)
		{
			_text = text;
		}
		
		public void ShowHealth(int amount)
		{
			_text.SetText(amount.ToString());
		}

		public void Destroy()
		{
			_text.Destroy();
		}
	}
}