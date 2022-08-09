using UnityEngine;


public class Player : Creature
{
    [SerializeField] private Transform _aim;
    [SerializeField] private Transform _aimRotationCenter;
    [SerializeField] private Cooldown _dash;
    public float dasdasd;
    public Weapon Weapon
    {
        get 
        {
            return CurrentWeapon;
        }
        set 
        {
            CurrentWeapon = Weapon;
            OnWeaponChange?.Invoke();
        }
    }
    private Animator _animator;

    private readonly int isRunningKey = Animator.StringToHash("is-running");
    private readonly int dashKey = Animator.StringToHash("dash");
    public delegate void OnChange();
    public event OnChange OnWeaponChange;

    protected override void Awake()
    {
        _animator = GetComponent<Animator>();
        base.Awake();
        Target = _aim;
        Cursor.visible = false;
    }
    private void Update()
    {
        if(WeaponObserver!= null) WeaponObserver.SetTarget(_aim.position);
        LookAtTarget();
    }
    public override void Move(Vector2 direction)
    {
        var isRunning = false;
        if(direction.x!=0 || direction.y != 0)
        {
            isRunning = true;
        }
        _animator.SetBool(isRunningKey, isRunning);

        base.Move(direction);
    }
    public override void LookAtTarget()
    {
        var difference = Target.position - transform.position;
        var directionX = difference.x > 0 ? 1 : -1;

        base.LookAtTarget();
        _aimRotationCenter.localScale = new Vector2(directionX, transform.localScale.y);
    }
    public override void TryEquipWeapon(GameObject weapon)
    {
        if (Weapon != null) return; 
        base.TryEquipWeapon(weapon);
        Weapon = weapon.GetComponent<Weapon>();
    }

    public void DoDash()
    {
        if (_dash.IsReady)
        {
            _animator.SetTrigger(dashKey);
            _dash.Reset();
        }
    }
    public void EnableWeaponCollider()
    {
        if (CurrentWeapon != null)
            CurrentWeapon.GetComponent<Collider2D>().enabled = true;
    }
    public void DisableWeaponCollider()
    {
        if (CurrentWeapon != null)
            CurrentWeapon.GetComponent<Collider2D>().enabled = false;
    }
}
