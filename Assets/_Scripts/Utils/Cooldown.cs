using System;
using UnityEngine;

[Serializable]
public class Cooldown
{
    [SerializeField] private float _cooldownTime;

    private float _timesUp;
    public void Reset()
    {
        _timesUp = Time.time + _cooldownTime;
    }
    public bool IsReady => _timesUp <= Time.time;
}
