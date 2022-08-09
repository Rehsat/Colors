using UnityEngine;
using System;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private Transform _spawnTrasfrom;
    private SystemData _systemData;
    private SessionData _sessionData;
    private void Awake()
    {
        _systemData = FindObjectOfType<SystemData>();
        _sessionData = FindObjectOfType<SessionData>();
    }
    public void SpawnEnemy()
    {
        var enemiesArray = _systemData.PossibleEnemies;

        var randomEnemyId = UnityEngine.Random.Range(0, enemiesArray.Length);
        var randomEnemyColor = (ColorType)UnityEngine.Random.Range(0, Enum.GetValues(typeof(ColorType)).Length);


        var enemyToSpawn = enemiesArray[randomEnemyId];
        var instantinate = Instantiate(enemyToSpawn.gameObject, _spawnTrasfrom.position, Quaternion.identity);

        var playerTransform = FindObjectOfType<Player>().transform;
        var instantinatedCreature = instantinate.GetComponent<Creature>();

        instantinatedCreature.SetColorType(randomEnemyColor);
        instantinatedCreature.SetTarget(playerTransform);

        _sessionData.ChageEnemyWeapon(instantinatedCreature);
        _sessionData.AddEnemy(instantinatedCreature);
    }
}
