using UnityEngine;

public class Observer2D : MonoBehaviour
{
    [SerializeField] private bool _mouseIsTarget;
    private Vector2 _target;
    private void Update()
    {
        LookAt2D(_target);
    }
    public void LookAt2D(Vector2 target)
    {
        Vector3 difference;
        if (_mouseIsTarget)
        {
            difference = Camera.main.ScreenToWorldPoint(target) - transform.position;
        }
        else
        {
            difference = target - (Vector2)transform.position;
        }
        Look(difference);
    }
    public void SetTarget(Vector2 target)
    {
        _target = target;
    }

    private void Look(Vector3 difference)
    {
        difference.Normalize();

        var directionY = difference.x > 0 ? 1 : -1;
        float rotationZ = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;

        transform.localScale = new Vector2(transform.localScale.x, directionY);
        transform.rotation = Quaternion.Euler(0f, 0f, rotationZ);
    }
}
