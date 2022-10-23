namespace GameLibrary.Rendering
{
	public interface IAliveRenderersGroup
	{
		void Add(IAliveRenderer gameObject);
		void Remove(IAliveRenderer gameObject);
	}
}