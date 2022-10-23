namespace GameLibrary.Rendering
{
	public class FakeMeshFactory : IMeshFactory
	{
		private readonly IAliveRenderersGroup _aliveRenderersGroup;

		public FakeMeshFactory(IAliveRenderersGroup aliveRenderersGroup)
		{
			_aliveRenderersGroup = aliveRenderersGroup;
		}
		
		public IMesh Create()
		{
			var mesh = new FakeMesh();
			_aliveRenderersGroup.Add(mesh);
			return mesh;
		}
	}
}