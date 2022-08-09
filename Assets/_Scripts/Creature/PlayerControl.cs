using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;

[RequireComponent(typeof(Player))]
public class PlayerControl : MonoBehaviour
{
    [SerializeField] private PlayerActions _input;
    private Player _player;
    private void Awake()
    {
        _input = new PlayerActions();
        _input.Enable();

        _player = GetComponent<Player>();
    }
    private void Start()
    {
        _input.PlayerMap.Shoot.started += ctx => OnStartShoot();
        _input.PlayerMap.Shoot.performed += ctx => OnStartShoot();
        _input.PlayerMap.Shoot.canceled += ctx => OnStopShoot();
        _input.PlayerMap.Dash.performed += ctx => OnDash();
        _input.PlayerMap.Drop.performed += ctx => OnDrop();
        _input.PlayerMap.MenuOpen.performed += ctx => OpenMenu();
        _input.PlayerMap.Restart.performed += ctx => Restart();
    }
    private void Update()
    {
        OnMove();
    }
    private void OnMove()
    {
        var direction = _input.PlayerMap.Movement.ReadValue<Vector2>();
        _player.Move(direction);
    }
    private void OnEnable()
    {
        _input.Enable();
    }
    private void OnDisable()
    {
        _input.Disable();
    }
    private void OnStartShoot()
    {
        _player.Shoot();
    }
    private void OnStopShoot()
    {
        _player.StopShoot();
    }
    private void OnDash()
    {
        _player.DoDash();
    }
    private void OnDrop()
    {
        _player.DropWeapon();
    }
    private void OpenMenu()
    {
        SceneManager.LoadScene(0);
    }
    private void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
