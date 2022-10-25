using GameLibrary.Lifetime;

namespace GameLibrary.Rendering
{
	public class FakeGraphicLibrary : IGraphicLibrary, IRenderer, IDeadStorage
	{
		private readonly AliveRenderersGroup _aliveRenderersGroup;
		
		public FakeGraphicLibrary()
		{
			_aliveRenderersGroup = new AliveRenderersGroup();
		}
		
		public ITextFactory TextFactory()
		{
			return new FakeTextFactory(_aliveRenderersGroup);
		}

		public IMeshFactory MeshFactory()
		{
			return new FakeMeshFactory(_aliveRenderersGroup);
		}

		public void Render(long elapsedMilliseconds)
		{
			_aliveRenderersGroup.Render(elapsedMilliseconds);
		}

		public void CleanupDeadObjects()
		{
			_aliveRenderersGroup.CleanupDeadObjects();
		}
	}
}