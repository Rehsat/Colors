using UnityEngine;
using System.Collections;

public class Weapon : MonoBehaviour
{
    [SerializeField] private float _damageScale;
    [SerializeField] private float _speedScale;
    [SerializeField] private ColorType _colorType;

    [SerializeField] private BulletMovement _bulletMovementPrefab;
    [SerializeField] private BulletSpawner[] _bulletSpawners;
    [SerializeField] private Bullet _bullet;

    private bool _isShooting;
    private Animator _animator;

    private const float DEFAULT_SPEED = 15;
    private const float DEFAULT_DAMAGE = 17;
    private const float DEFAULT_LIFE_TIME = 24;

    private readonly int isShootingKey = Animator.StringToHash("is-shooting");
    private void Awake()
    {
        _animator = GetComponent<Animator>();
        GenerateBullet();
        SetColorType(_colorType);
    }
    public void GenerateBullet()
    {
        _bullet = new Bullet(_damageScale * DEFAULT_DAMAGE, 
            _speedScale * DEFAULT_SPEED, 
            DEFAULT_LIFE_TIME, 
            _colorType);
        foreach (var bulletSpawner in _bulletSpawners)
        {
            bulletSpawner.SetBullet(_bullet);
            bulletSpawner.SetObjectToSpawn(_bulletMovementPrefab.gameObject);
        }
    }
    public void Shoot()
    {
        foreach(var bulletSpawner in _bulletSpawners)
        {
            bulletSpawner.Spawn();
        }
    }
    public void SetShootingState(bool state)
    {
        _isShooting = state;
        _animator.SetBool(isShootingKey, _isShooting);
    }
    public void SetColorType(ColorType colorType)
    {
        _colorType = colorType;
        _bulletMovementPrefab.SetColoType(colorType);
    }
    public void SetBulletType(BulletMovement type)
    {
        _bulletMovementPrefab = type;
    }

    
}
