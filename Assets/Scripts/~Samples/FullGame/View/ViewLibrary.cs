using GameLibrary.Rendering;

namespace GameLibrary.Sample
{
	public class ViewLibrary : IViewLibrary
	{
		private readonly IGraphicLibrary _graphicLibrary;

		public ViewLibrary(IGraphicLibrary graphicLibrary)
		{
			_graphicLibrary = graphicLibrary;
		}
		
		public ICharacterViewFactory CharacterViewFactory()
		{
			return new CharacterViewFactory(_graphicLibrary.TextFactory());
		}

		public IBulletViewFactory BulletViewFactory()
		{
			return new BulletViewFactory(_graphicLibrary.MeshFactory());
		}
	}
}