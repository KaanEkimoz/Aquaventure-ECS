using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Entitas;
using Unity.Mathematics;
using Random = UnityEngine.Random;

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
            var speed = GameConfig.Instance.enemySpeed;
            var range = GameConfig.Instance.enemyRange;
            var x = Mathf.Cos(Time.time * speed) * range;
            enemy.ReplacePosition(x,enemy.position.y, enemy.position.z);
        }
    }
}