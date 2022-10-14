using System.Collections.Generic;
using System.Linq;

namespace GameLibrary
{
    public class GameObjectsGroup : IGameObjectsGroup
    {
        private readonly List<IGameObject> _gameObjects = new();

        public GameObjectsGroup()
        {
        }

        public GameObjectsGroup(IGameObject[] gameObjects)
        {
            _gameObjects = gameObjects.ToList();
        }

        public void ExecuteTick(long elapsedMilliseconds)
        {
            _gameObjects.RemoveAll(gameObject => !gameObject.IsAlive);

            foreach (var gameObject in _gameObjects)
            {
                if (gameObject.IsAlive)
                    gameObject.ExecuteTick(elapsedMilliseconds);
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