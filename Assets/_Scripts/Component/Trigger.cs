using UnityEngine;

public class Trigger : MonoBehaviour
{
    [SerializeField] private LayerMask _layer;
    [SerializeField] private EnterEvent _onEnter;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        var eventGameObject = collision.gameObject;
        if (eventGameObject.IsInLayer(_layer))
        {
            _onEnter?.Invoke(eventGameObject);
        }
    }
}
