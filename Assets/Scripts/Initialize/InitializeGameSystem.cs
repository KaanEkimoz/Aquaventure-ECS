using Entitas;
public class InitializeGameSystem : IInitializeSystem
{
    private readonly Contexts _contexts;
    public InitializeGameSystem(Contexts contexts)
    {
        _contexts = contexts;
    }
    public void Initialize() 
    {
        
    }
    
}