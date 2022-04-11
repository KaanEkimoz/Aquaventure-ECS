using Entitas;
public class InitializePlayerSystem : IInitializeSystem
{
    private readonly Contexts _contexts;
    public InitializePlayerSystem(Contexts contexts)
    {
        _contexts = contexts;
    }

    public void Initialize()
    {
        var player = _contexts.game.CreateEntity();
        player.AddPosition(0,0,0);
        player.AddResource(GameConfig.Instance.playerPrefab);
        player.AddDirection(Direction.Left);
        player.isPlayer = true;
        

    }
}