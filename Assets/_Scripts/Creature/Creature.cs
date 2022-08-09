using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Creature : MonoBehaviour
{
    [SerializeField] protected float _speed;
    [SerializeField] protected Weapon CurrentWeapon;
    [SerializeField] private float _takeDamageForce;
    [SerializeField] private Transform _weaponHoldingTransform;

    [SerializeField] private ColorType _colorType;
    private SessionData _session;
    public ColorType Color => _colorType;

    protected Transform Target;
    protected Observer2D WeaponObserver;
    protected Rigidbody2D Rigidbody;
    protected Vector2 Direction;

    public Transform CurrentTarget => Target;

    protected virtual void Awake()
    {
        if (CurrentWeapon != null) WeaponObserver = CurrentWeapon.gameObject.GetComponent<Observer2D>();
        Rigidbody = GetComponent<Rigidbody2D>();
        _session = FindObjectOfType<SessionData>();
    }
    private void Start()
    {
        if (_colorType != ColorType.Normal) gameObject.ChangeColorByType(_colorType);
            
    }
    private void Update()
    {
        if (Target != null && WeaponObserver!= null)
        {
            WeaponObserver.SetTarget(Target.position);
        }
    }
    public void SetTarget(Transform target)
    {
        Target = target;
    }
    public void SetColorType(ColorType colorType)
    {
        _colorType = colorType;
        gameObject.ChangeColorByType(_colorType);
        CurrentWeapon.SetColorType(_colorType);
    }
    public void DropWeapon()
    {
        if (CurrentWeapon != null)
            Destroy(CurrentWeapon.gameObject);
    }
    public virtual void Move(Vector2 direction)
    {
        Direction = direction;
        var movement = _speed * direction;
        Rigidbody.velocity = movement;
    }
    public void Shoot()
    {
        if(CurrentWeapon != null)
           CurrentWeapon.SetShootingState(true);
    }
    public void StopShoot()
    {
        if (CurrentWeapon != null)
            CurrentWeapon.SetShootingState(false);
    }
    public void OnDie()
    {
        _session.RemoveEnemy(this);
    }
    public void OnTakeDamage(GameObject damager)
    {
        var damagerPosition = damager.transform.position;

        var differenceX = transform.position.x - damagerPosition.x;
        var differenceY = transform.position.y - damagerPosition.y;

        var damagerForceXDelta = differenceX > 0 ? 1 : -1;
        var damagerForceYDelta = differenceY > 0 ? 1 : -1;

        Vector2 velocity = new Vector2(damagerForceXDelta, damagerForceYDelta) * _takeDamageForce;
        Rigidbody.velocity += velocity;

    }

    public virtual void LookAtTarget()
    {
        var difference = Target.position - transform.position;
        var directionX = difference.x > 0 ? 1 : -1;

        if (CurrentWeapon != null)
        {
            var weaponTransform = CurrentWeapon.gameObject.transform;
            weaponTransform.localScale = new Vector2(-directionX, weaponTransform.localScale.y);
        }

        transform.localScale = new Vector2(directionX, transform.localScale.y);
    }

    public virtual void TryEquipWeapon(GameObject weapon)
    {

        weapon.transform.position = _weaponHoldingTransform.position;
        weapon.transform.parent = _weaponHoldingTransform;
        weapon.transform.localScale = new Vector2(-1, 1); //Хардкод для фикса бага, при наличии времени - исправить
        weapon.ChangeColorByType(_colorType);

        CurrentWeapon = weapon.GetComponent<Weapon>();
        CurrentWeapon.GenerateBullet();
        CurrentWeapon.SetColorType(_colorType);
        WeaponObserver = CurrentWeapon.gameObject.GetComponent<Observer2D>();
    }
}
public enum ColorType
{
    Red,
    Green,
    Blue,
    Normal
}
