using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawner : MonoBehaviour
{
    [SerializeField] private GameObject _objectToSpawn;
    [SerializeField] private Transform _spawnTransform;
    private Bullet _bullet;

    public void Spawn()
    {
        var instantinate = Instantiate(_objectToSpawn, _spawnTransform.position, _spawnTransform.rotation);
        instantinate.GetComponent<BulletMovement>().SetBullet(_bullet);
    }
    public void SetBullet(Bullet bullet)
    {
        _bullet = bullet;
    }
    public void SetObjectToSpawn(GameObject newObjectToSpawn)
    {
        _objectToSpawn = newObjectToSpawn;
    }
}
