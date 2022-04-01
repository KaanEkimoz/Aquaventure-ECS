using Entitas;
using Entitas.CodeGeneration.Attributes;

[Game,Event(EventTarget.Self)]
public class PositionComponent : IComponent
{
    public float x;
    public float y;
    public float z;
}