using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthChanger : MonoBehaviour
{
    [SerializeField] private float _changeValue;
    public void ChangeHealth(GameObject objectToChange)
    {
        var health = objectToChange.GetComponent<HealthComponent>();
        if (health == null) return;

        health.ApplyChanges(_changeValue);
    }
    public void SetChangeValue(float value)
    {
        _changeValue = value;
    }
}
