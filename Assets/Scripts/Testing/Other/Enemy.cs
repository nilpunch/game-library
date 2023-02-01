using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public interface IEnemy
{
    bool IsAlive { get; }
}

public interface IEnemies
{
    void Add(IEnemy enemy);
    void Remove(IEnemy enemy);
}

public interface IRandomEnemy
{
    void Add(IEnemy enemy);
    void Remove(IEnemy enemy);
}

public interface IGameSession
{
    bool IsEnded { get; }
}




public class Enemy : MonoBehaviour, IEnemy
{
    public bool IsAlive { get; }
}

public class Enemies : MonoBehaviour
{

}

public class GameSession : MonoBehaviour, IGameSession
{
    [SerializeField] private Enemy[] _enemies;

    public bool IsEnded => _enemies.All(enemy => !enemy.IsAlive);
}


public class App : MonoBehaviour
{
    [SerializeField] private GameSession _gameSession;

    private void Update()
    {
        if (_gameSession.IsEnded)
            Application.Quit();
    }
}
