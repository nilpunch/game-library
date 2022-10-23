using GameLibrary.Rendering;

namespace GameLibrary.Sample
{
	public class BulletViewFactory : IBulletViewFactory
	{
		private readonly IMeshFactory _meshFactory;

		public BulletViewFactory(IMeshFactory meshFactory)
		{
			_meshFactory = meshFactory;
		}
		
		public IBulletView Create()
		{
			return new BulletView(_meshFactory.Create());
		}
	}
}