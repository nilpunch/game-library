using System;
using System.Collections.Generic;
using System.Linq;

namespace GameLibrary
{
    public class GameObjectsGroup : IGameObjectsGroup, ISimulationObject
    {
        private readonly List<IGameObject> _gameObjects;

        public GameObjectsGroup() : this(Array.Empty<IGameObject>())
        {
        }

        public GameObjectsGroup(IGameObject[] gameObjects)
        {
            _gameObjects = gameObjects.ToList();
        }

        public void Step(long elapsedMilliseconds)
        {
            foreach (var gameObject in _gameObjects)
            {
                if (gameObject.IsAlive)
                    gameObject.Step(elapsedMilliseconds);
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
