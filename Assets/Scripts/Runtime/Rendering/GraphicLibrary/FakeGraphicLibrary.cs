namespace GameLibrary.Rendering
{
	public class FakeGraphicLibrary : IGraphicLibrary, IRenderer
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
			_aliveRenderersGroup.CleanupDeadObjects();
			
			_aliveRenderersGroup.Render(elapsedMilliseconds);
		}
	}
}