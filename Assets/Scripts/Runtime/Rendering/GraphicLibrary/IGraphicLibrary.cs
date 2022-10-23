namespace GameLibrary.Rendering
{
	public interface IGraphicLibrary
	{
		public ITextFactory TextFactory();
		public IMeshFactory MeshFactory();
	}
}