using System;
using UnityEngine.InputSystem;
using Entitas;
using UnityEngine;


public class EntitasInputSystem : IExecuteSystem, ICleanupSystem  
{
    private readonly Contexts _contexts;
    private IGroup<InputEntity> _inputs;
    private EntitasInputActions _inputActions;
    private Vector2 _moveDirection;

    public EntitasInputSystem(Contexts contexts)
    {
        _contexts = contexts;
        _inputs = contexts.input.GetGroup(InputMatcher.AnyOf(InputMatcher.Input,InputMatcher.KeyDown));
        
        _inputActions = new EntitasInputActions();
        _inputActions.Enable();
    }

    public void Execute()
    {
        _moveDirection = _inputActions.Player.Move.ReadValue<Vector2>();

        var inputEntity = _contexts.input.CreateEntity();
        inputEntity.AddInput(_moveDirection);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            var keyActionEntity = _contexts.input.CreateEntity();
            keyActionEntity.AddKeyDown(KeyCode.Space);
        }
        
        
    }

    void CreateKeyDownEntity()
    {
        var keyActionEntity = _contexts.input.CreateEntity();
        keyActionEntity.AddKeyDown(KeyCode.Space);
    }

    public void Cleanup()
    {
        foreach (var e in _inputs.GetEntities())
        {
            e.Destroy();
        }
    }
}