using Entitas;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private Systems _systems;
    private void Start()
    {
        _systems = new Feature ("Systems")
            .Add(new InitializeGameSystem(Contexts.sharedInstance))
            .Add(new ResourceSystem(Contexts.sharedInstance))
            .Add(new EnemyMovementSystem(Contexts.sharedInstance))
            .Add(new GameEventSystems(Contexts.sharedInstance));
        _systems.Initialize();
    }
    private void Update()
    {
        _systems.Execute();
        _systems.Cleanup();
    }
    private void OnDestroy()
    {
        _systems.TearDown();
    }
}
