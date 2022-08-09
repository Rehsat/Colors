using UnityEngine;

[RequireComponent(typeof(Spawner))]
public class WeaponSpawner : MonoBehaviour
{
    [SerializeField] private ColorType _weaponColor;
    [SerializeField] private Transform _spawnTrasfrom;
    private SystemData _systemData;
    private GameObject _instantinatedWeapon;
    private void Awake()
    {
        _systemData = FindObjectOfType<SystemData>();
        TrySpawnWeapon();
    }
    public void TrySpawnWeapon()
    {
        if (_instantinatedWeapon != null) return;

        var weaponsArray = _systemData.PossibleWeapons;
        var bulletsArray = _systemData.PossibleBulletMovementTypes;

        var randomWeaponId = Random.Range(0, weaponsArray.Length);
        var randomBulletType = Random.Range(0, bulletsArray.Length);

        var weaponToSpawn = weaponsArray[randomWeaponId];
        var instantinate = Instantiate(weaponToSpawn.gameObject, _spawnTrasfrom.position, Quaternion.identity);
        instantinate.ChangeColorByType(_weaponColor);

        var instantinatedWeapon = instantinate.GetComponent<Weapon>();

        instantinatedWeapon.SetColorType(_weaponColor);
        instantinatedWeapon.SetBulletType(bulletsArray[randomBulletType]);

        _instantinatedWeapon = instantinatedWeapon.gameObject;
    }
}
