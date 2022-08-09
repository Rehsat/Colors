using UnityEngine;
using UnityEngine.UI;

public class HealthBarWidget : MonoBehaviour
{
    [SerializeField] private HealthComponent _health;
    [SerializeField] private Image _healthBar;
    private void Start()
    {
        _health.OnHealthChanged += ChangeFillAmount;
    }
    private void ChangeFillAmount()
    {
        var changeValue = _health.CurrentHealth / _health.MaxHealth;
        _healthBar.fillAmount = changeValue;
    }
    private void OnDestroy()
    {
        _health.OnHealthChanged -= ChangeFillAmount;
    }
}