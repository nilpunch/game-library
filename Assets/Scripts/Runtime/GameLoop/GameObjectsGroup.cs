using System.Collections.Generic;
using System.Linq;

namespace PhysicsSample
{
    public class GameObjectsGroup : IGameObjectsLoop
    {
        private readonly List<IGameObject> _gameObjects = new();

        public GameObjectsGroup()
        {
        }

        public GameObjectsGroup(IGameObject[] gameObjects)
        {
            _gameObjects = gameObjects.ToList();
        }
        
        public void ExecuteFrame(long elapsedTime)
        {
            _gameObjects.RemoveAll(gameObject => !gameObject.IsActual);

            foreach (var gameObject in _gameObjects)
            {
                if (gameObject.IsActual)
                    gameObject.ExecuteFrame(elapsedTime);
            }
        }

        public void Add(IGameObject gameObject)
        {
            _gameObjects.Add(gameObject);
        }

        public void Remove(IGameObject gameObject)
        {
            _gameObjects.Remove(gameObject);
        }
    }
}