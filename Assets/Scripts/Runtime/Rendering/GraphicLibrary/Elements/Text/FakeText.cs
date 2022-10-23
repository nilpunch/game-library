using System;

namespace GameLibrary.Rendering
{
	public class FakeText : IText, IAliveRenderer
	{
		public bool IsAlive { get; private set; } = true;

		public void Destroy()
		{
			if (!IsAlive)
				throw new Exception();
			
			IsAlive = false;
		}

		public void Render(long elapsedMilliseconds)
		{
			if (!IsAlive)
				throw new Exception();
		}

		public void SetText(string text)
		{
		}
	}
}