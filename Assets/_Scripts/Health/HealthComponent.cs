using UnityEngine.Events;
using UnityEngine;

public class HealthComponent : MonoBehaviour
{
    [SerializeField] private float _maxHealth;
    [SerializeField] private UnityEvent _onTakeDamage;
    [SerializeField] private UnityEvent _onDie;
    [SerializeField] private float _currentHealth;
    private bool _isInvincible;
    public float MaxHealth => _maxHealth;
    public float CurrentHealth
    {
        get
        {
            return _currentHealth;
        }
        set
        {
            _currentHealth = value;
            OnHealthChanged?.Invoke();
        }
    }

    public delegate void OnChanged();
    public event OnChanged OnHealthChanged;
    public void ApplyChanges(float value)
    {

        if(_isInvincible) return;
        if (CurrentHealth < 0) return;
        if (value < 0) _onTakeDamage?.Invoke(); 

        CurrentHealth += value;

        if (CurrentHealth > _maxHealth) _currentHealth = _maxHealth;
        if (CurrentHealth<0) _onDie?.Invoke();
    }
    public void SetInvincible()
    {
        _isInvincible = true;
    }
    public void UnsetInvincible()
    {
        _isInvincible = false;
    }
}
