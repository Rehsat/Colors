using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SessionData : MonoBehaviour
{
    [SerializeField] private Player _player;
    [SerializeField] private AnimationCurve _difficultCurve;
    [SerializeField] private float _difficult;
    private float _currentTime;
    private List<Creature> _enemies;
    public List<Creature> Enemies => _enemies;
    public float Difficult => _difficult;

    public delegate void OnChange(Creature enemy);
    public event OnChange OnEnemyAdd;
    public event OnChange OnEnemyRemove;

    private void Awake()
    {
        _player.OnWeaponChange += ChangeEnemiesWeapon;
        _enemies = new List<Creature>(50);
    }
    private void Update()
    {
        _difficult = _difficultCurve.Evaluate(_currentTime);
        _currentTime += Time.deltaTime;
    }
    private void ChangeEnemiesWeapon()
    {
        var enemies = FindObjectsOfType<MobAI>();
        foreach(var enemy in enemies)
        {

            var enemyCreature = enemy.GetComponent<Creature>();
            ChageEnemyWeapon(enemyCreature);
        }
    }
    public void ChageEnemyWeapon(Creature enemyCreature)
    {
        enemyCreature.DropWeapon();
        if (_player.Weapon!= null)
        {
            var copyOfWeaponPlayer = Instantiate(_player.Weapon.gameObject);
            enemyCreature.TryEquipWeapon(copyOfWeaponPlayer);
        }
    }
    private void OnDestroy()
    {
        _player.OnWeaponChange -= ChangeEnemiesWeapon;
    }
    public void AddEnemy(Creature enemy)
    {
        _enemies.Add(enemy);
        OnEnemyAdd?.Invoke(enemy);
    }
    public void RemoveEnemy(Creature enemy)
    {
        _enemies.Remove(enemy);
        OnEnemyRemove?.Invoke(enemy);
    }
}
