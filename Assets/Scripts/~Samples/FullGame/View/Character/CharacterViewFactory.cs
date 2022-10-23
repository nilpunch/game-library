using GameLibrary.Rendering;

namespace GameLibrary.Sample
{
	public class CharacterViewFactory : ICharacterViewFactory
	{
		private readonly ITextFactory _textFactory;

		public CharacterViewFactory(ITextFactory textFactory)
		{
			_textFactory = textFactory;
		}
		
		public ICharacterView Create()
		{
			return new CharacterView(_textFactory.Create());
		}
	}
}