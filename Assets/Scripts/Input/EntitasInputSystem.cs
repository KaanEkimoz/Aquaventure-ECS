using UnityEngine.InputSystem;
using Entitas;
using UnityEngine;

public class EntitasInputSystem : IExecuteSystem  
{
    private readonly Contexts _contexts;
    private EntitasInputActions _inputActions;
    private Vector2 _moveDirection;

    public EntitasInputSystem(Contexts contexts)
    {
        _contexts = contexts;
        
        _inputActions = new EntitasInputActions();
        _inputActions.Enable();
    }

    public void Execute()
    {
        _moveDirection = _inputActions.Player.Move.ReadValue<Vector2>() * Time.deltaTime * GameConfig.Instance.playerSpeed;

        var InputEntity = _contexts.input.CreateEntity();
        InputEntity.AddInput(_moveDirection);
    }
}