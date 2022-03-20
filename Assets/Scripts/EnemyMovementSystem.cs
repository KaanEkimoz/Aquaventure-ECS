using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Entitas;

public class EnemyMovementSystem : IExecuteSystem  
{
    private readonly Contexts _contexts;
    private IGroup<GameEntity> _enemyEntities;

    public EnemyMovementSystem(Contexts contexts)
    {
        _contexts = contexts;
        _enemyEntities = _contexts.game.GetGroup(GameMatcher.Enemy);
    }

    public void Execute() 
    {
        foreach (var enemy in _enemyEntities)
        {
            enemy.ReplacePosition(Mathf.Cos(Time.time),enemy.position.y, enemy.position.z);
        }
    }
}