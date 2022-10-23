namespace GameLibrary.Sample.MV
{
	public class Model : ISimulationTick, IVisualisation
	{
		private readonly ISimulationTick _gameLoop;
		private readonly IVisualisation _visualisation;

		public Model()
		{
			// Collect all view's to render
			var visualisations = new VisualisationGroup();

			var firstCharacterView = new CharacterView();
			var secondCharacterView = new CharacterView();
			
			visualisations.Add(firstCharacterView);
			visualisations.Add(secondCharacterView);
			
			var characters = new SimulationTickGroup(new ISimulationTick[]
			{
				new Character(10, firstCharacterView),
				new Character(10, secondCharacterView),
			});

			_gameLoop = characters;
			_visualisation = visualisations;
		}
		
		// This will be called from simulation
		public void ExecuteTick(long elapsedMilliseconds)
		{
			_gameLoop.ExecuteTick(elapsedMilliseconds);
		}

		// This will be called independently
		public void Render(long elapsedMilliseconds)
		{
			_visualisation.Render(elapsedMilliseconds);
		}
	}
}