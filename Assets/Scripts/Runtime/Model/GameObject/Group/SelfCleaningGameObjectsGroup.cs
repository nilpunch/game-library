using System;
using System.Collections.Generic;
using System.Linq;

namespace GameLibrary.Lifetime
{
    public class SelfCleaningGameObjectsGroup : IGameObjectsGroup, ISimulationObject
    {
        private readonly GameObjectsGroup _gameObjectsGroup;
        private readonly List<IGameObject> _gameObjects;

        public SelfCleaningGameObjectsGroup() : this(Array.Empty<IGameObject>())
        {
        }

        public SelfCleaningGameObjectsGroup(IGameObject[] gameObjects)
        {
            _gameObjectsGroup = new GameObjectsGroup(gameObjects);
            _gameObjects = gameObjects.ToList();
        }

        public void Step(long elapsedMilliseconds)
        {
            CleanupNotAlive();

            _gameObjectsGroup.Step(elapsedMilliseconds);
        }

        public void Add(IGameObject gameObject)
        {
            _gameObjects.Add(gameObject);
            _gameObjectsGroup.Add(gameObject);
        }

        public void Remove(IGameObject gameObject)
        {
            _gameObjects.Remove(gameObject);
            _gameObjectsGroup.Remove(gameObject);
        }

        private void CleanupNotAlive()
        {
            _gameObjects.RemoveAll(gameObject =>
            {
                if (!gameObject.IsAlive)
                {
                    _gameObjectsGroup.Remove(gameObject);
                }
                return !gameObject.IsAlive;
            });
        }
    }
}
