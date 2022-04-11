using Entitas.Unity;
using UnityEngine;
public class UnityViewObject : MonoBehaviour, IPositionListener
{
    private GameEntity _linkedEntity;
    public void LinkObject(GameEntity entity)
    {
        _linkedEntity = entity;
        gameObject.Link(_linkedEntity);
        
        //Adding this.gameObject as a Listener to _linkedEntity
        _linkedEntity.AddPositionListener(this);
    }
    public void OnPosition(GameEntity entity, float x, float y, float z)
    {
        transform.position = new Vector3(x, y, z);
    }

    private void OnTriggerEnter(Collider other)
    {
        _linkedEntity.isDestroy = true;
    }
}
