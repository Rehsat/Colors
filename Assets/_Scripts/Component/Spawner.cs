using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject _objectToSpawn;
    [SerializeField] private Transform _spawnTransform;

    public void Spawn()
    {
        Debug.Log(_objectToSpawn);
       Instantiate(_objectToSpawn, _spawnTransform.position, _spawnTransform.rotation);
    }

    public void SetObjectToSpawn(GameObject newObjectToSpawn)
    {
        _objectToSpawn = newObjectToSpawn;
    }
}
