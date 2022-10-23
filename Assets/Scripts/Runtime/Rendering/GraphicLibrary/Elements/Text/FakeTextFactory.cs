namespace GameLibrary.Rendering
{
	public class FakeTextFactory : ITextFactory
	{
		private readonly IAliveRenderersGroup _aliveRenderersGroup;

		public FakeTextFactory(IAliveRenderersGroup aliveRenderersGroup)
		{
			_aliveRenderersGroup = aliveRenderersGroup;
		}
		
		public IText Create()
		{
			var text = new FakeText();
			
			_aliveRenderersGroup.Add(text);
			
			return text;
		}
	}
}