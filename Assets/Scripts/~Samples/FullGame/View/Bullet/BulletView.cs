using GameLibrary.Rendering;

namespace GameLibrary.Sample
{
	public class BulletView : IBulletView
	{
		private readonly IMesh _mesh;

		public BulletView(IMesh mesh)
		{
			_mesh = mesh;
		}
		
		public void Destroy()
		{
			_mesh.Destroy();
		}
	}
	
	
}