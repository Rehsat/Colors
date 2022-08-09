using UnityEngine.InputSystem;
using UnityEngine;

[RequireComponent(typeof(Observer2D))]
public class LookAtMouse : MonoBehaviour
{
    private Observer2D _observer;
    private Vector2 _mousePosition;
    void Awake()
    {
        _observer = GetComponent<Observer2D>();
    }

    void Update()
    {
        _mousePosition = Mouse.current.position.ReadValue();
        _observer.SetTarget(_mousePosition);
    }
}
