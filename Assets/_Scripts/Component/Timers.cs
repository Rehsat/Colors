using System.Collections;
using System;
using UnityEngine;
using UnityEngine.Events;

public class Timers : MonoBehaviour
{
    [SerializeField] private Timer[] _timers;
    [SerializeField] private bool _setTimerOnStart;
    [SerializeField] private int _startTimerId;
    private void Start()
    {
        StartTimer(_startTimerId);
    }
    public void StartTimer(int id)
    {
        StartCoroutine(WaitingForTimer(id));
    }
    private IEnumerator WaitingForTimer(int id)
    {
        while (true)
        {
            var timer = _timers[id];
            yield return new WaitForSeconds(timer.TimeToEvent);
            timer.Event?.Invoke();
            if (!timer.IsCycle) break;
        }
    }
}
[Serializable]
public class Timer
{
    [SerializeField] private float _timeToEvent;
    [SerializeField] private UnityEvent _event;
    [SerializeField] private bool _isCycle;
    public float TimeToEvent => _timeToEvent;
    public UnityEvent Event => _event;
    public bool IsCycle => _isCycle;
}
