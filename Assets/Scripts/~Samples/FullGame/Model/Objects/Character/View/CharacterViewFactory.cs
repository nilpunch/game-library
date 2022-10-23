namespace GameLibrary.Sample.FullGame
{
    public class CharacterViewFactory : ICharacterViewFactory
    {
        private readonly IAliveVisualisationGroup _visualisationGroup;

        public CharacterViewFactory(IAliveVisualisationGroup visualisationGroup)
        {
            _visualisationGroup = visualisationGroup;
        }
        
        public ICharacterView Create()
        {
            var characterView = new CharacterView();
            
            _visualisationGroup.Add(characterView);

            return characterView;
        }
    }
}