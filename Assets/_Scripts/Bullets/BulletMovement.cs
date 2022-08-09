using UnityEngine;
using System;
using System.Collections;

[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(HealthChanger))]
public class BulletMovement : MonoBehaviour
{
    [SerializeField] protected Bullet CurrentBullet;
    private HealthChanger _healthChanger;
    protected Rigidbody2D Rigidbody;

    protected virtual void Start()
    {
        _healthChanger = GetComponent<HealthChanger>();
        Rigidbody = GetComponent<Rigidbody2D>();

        var force = new Vector2(CurrentBullet.Speed, 0);
        Rigidbody.AddRelativeForce(force, ForceMode2D.Impulse);
        
        
    }
    public void SetColoType(ColorType colorType)
    {
        gameObject.ChangeColorByType(colorType);
    }
    public void SetBullet(Bullet bullet)
    {
        CurrentBullet = bullet;
        gameObject.ChangeColorByType(CurrentBullet.BulletColor);
    }
    private void OnBecameVisible()
    {
        StartCoroutine(Living());
    }
    private IEnumerator Living()
    {
        yield return new WaitForSeconds(CurrentBullet.Speed);
    }
    
    public void DealDamage(GameObject target)
    {
        var health = target.GetComponent<HealthComponent>();
        if (health == null)
        {
            return;
        }

        var creature = target.GetComponent<Creature>();
        if(creature != null)
        {
            if (creature.Color == CurrentBullet.BulletColor || creature.Color == ColorType.Normal)
            {
                _healthChanger.SetChangeValue(-CurrentBullet.Damage);
                _healthChanger.ChangeHealth(target);
            }
            return;
        }
        _healthChanger.SetChangeValue(-CurrentBullet.Damage);
        _healthChanger.ChangeHealth(target);
    }
}
[Serializable]
public class Bullet
{
    [SerializeField] private float _damage;
    [SerializeField] private float _speed;
    [SerializeField] private float _lifeTime = 10;

    private ColorType _colorType = ColorType.Red;
    public ColorType BulletColor => _colorType;
    public float Speed => _speed;
    public float Damage => _damage;

    public Bullet(float damage, float speed, float lifeTime, ColorType colorType)
    {
        _damage = damage;
        _speed = speed;
        _lifeTime = lifeTime;
        _colorType = colorType;
    }

}
