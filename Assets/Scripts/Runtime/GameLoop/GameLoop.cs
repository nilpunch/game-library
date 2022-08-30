using System.Collections.Generic;
using System.Linq;

namespace PhysicsSample
{
    public class GameLoop : IGameLoop
    {
        private readonly List<IGameObject> _gameObjects = new();
        private readonly HashSet<IGameObject> _objectsToAdd = new();
        private readonly HashSet<IGameObject> _objectsToRemove = new();

        public void ExecuteFrame(long elapsedTime)
        {
            _gameObjects.AddRange(_objectsToAdd);
            _objectsToAdd.Clear();

            foreach (var gameObject in _objectsToRemove)
                _gameObjects.Remove(gameObject);
            _objectsToRemove.Clear();
            
            foreach (var gameObject in _gameObjects)
            {
                if (gameObject.IsActual)
                    gameObject.ExecuteFrame(elapsedTime);
            }
        }

        public void Add(IGameObject gameObject)
        {
            _objectsToAdd.Add(gameObject);
        }

        public void RemoveAllInactual()
        {
            foreach (var gameObject in _gameObjects.Where(gameObject => !gameObject.IsActual))
                _objectsToRemove.Add(gameObject);
        }
    }
}