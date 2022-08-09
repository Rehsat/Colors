using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MobAI : MonoBehaviour
{
    [SerializeField] private float _secondsToFindPlayerPosition;
    [SerializeField] private Transform _target;
    [SerializeField] private LayerChecker _playerChecker;

    private Creature _creature;
    private void Start()
    {
        _creature = GetComponent<Creature>();
        if (_target == null) _target = _creature.CurrentTarget;
        _creature.SetTarget(_target);
        StartCoroutine(MoveToTarget());
    }
    public void StartState(IEnumerator state)
    {
        StopAllCoroutines();
        StartCoroutine(state);
    }
    private IEnumerator MoveToTarget()
    {
        while(true)
        {
            var direction = CalculateDirection();
            _creature.Move(direction);
            if (_playerChecker.IsTouchingLayer) StartState(ShootTarget());
            yield return new WaitForSeconds(_secondsToFindPlayerPosition);
        }
    }

    private Vector2 CalculateDirection()
    {
        var difference = _target.position - transform.position;
        float directionX, directionY;

        if (Mathf.Abs(difference.x) < 1) directionX = 0;
        else directionX = difference.x >= 0 ? 1 : -1;

        if (Mathf.Abs(difference.y) < 1) directionY = 0;
        else directionY = difference.y >= 0 ? 1 : -1;

        var direction = new Vector2(directionX, directionY);
        return direction;
    }
    private IEnumerator ShootTarget()
    {
        _creature.SetTarget(_target);
        _creature.Shoot();
        yield return new WaitForSeconds(_secondsToFindPlayerPosition);

        if(!_playerChecker.IsTouchingLayer) _creature.StopShoot();

        StartState(MoveToTarget());
    }
        
}
