using Entitas;

public class InitializeEnemySystem : IInitializeSystem
{
    private readonly Contexts _contexts;

    public InitializeEnemySystem(Contexts contexts)
    {
        _contexts = contexts;
    }

    public void Initialize() 
    {
        for(int i = 0; i < 10; i++)
        {
            CreateEnemy(i * 1.2f);
        }
    }
    
    public void CreateEnemy(float yOffset)
    {
        var enemy = _contexts.game.CreateEntity();
        enemy.AddPosition(0, yOffset, 0);
        enemy.isEnemy = true;
        enemy.AddResource(GameConfig.Instance.enemyPrefab);

        // var playerEntity = _contexts.game.CreateEntity();
        // playerEntity.AddResource(GameConfig.Instance.playerPrefab);
    }
}