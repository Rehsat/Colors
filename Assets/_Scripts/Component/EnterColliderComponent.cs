using System;
using UnityEngine.Events;
using UnityEngine;

public class EnterColliderComponent : MonoBehaviour
{
    [SerializeField] private LayerMask _layer;
    [SerializeField] private EnterEvent _onEnter;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        var eventGameObject = collision.gameObject;
        if (eventGameObject.IsInLayer(_layer))
        {
            _onEnter?.Invoke(eventGameObject);
        }
    }
}
[Serializable]
public class EnterEvent : UnityEvent<GameObject>
{
}
