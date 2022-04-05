using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Entitas;

[Input]
public class InputComponent : IComponent
{
    public Vector2 moveDirection;
}