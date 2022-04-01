using UnityEngine;
using Entitas;
using Entitas.CodeGeneration.Attributes;using UnityEditor.SceneManagement;

[Game]
public class ResourceComponent : IComponent
{
    public GameObject instance;
}