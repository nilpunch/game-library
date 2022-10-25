using GameLibrary.Lifetime;

namespace GameLibrary.Rendering
{
	public interface IMesh : IAlive
	{
		void Destroy();
	}
}