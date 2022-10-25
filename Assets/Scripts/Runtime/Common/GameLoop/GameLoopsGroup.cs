using System.Collections.Generic;
using System.Linq;

namespace GameLibrary.GameLoop
{
    public class GameLoopsGroup : IGameLoop, IGameLoopsGroup
    {
        private readonly List<IGameLoop> _gameLoops = new();

        public GameLoopsGroup()
        {
        }

        public GameLoopsGroup(IGameLoop[] gameLoops)
        {
            _gameLoops = gameLoops.ToList();
        }

        public void Update(long elapsedMilliseconds)
        {
            foreach (var gameLoop in _gameLoops)
            {
                gameLoop.Update(elapsedMilliseconds);
            }
        }

        public void Add(IGameLoop gameLoop)
        {
            _gameLoops.Add(gameLoop);
        }

        public void Remove(IGameLoop gameLoop)
        {
            _gameLoops.Remove(gameLoop);
        }
    }
}