using UnityEngine.UI;
using UnityEngine;

public class EnemyCounterWidget : MonoBehaviour
{
    [SerializeField] private ColorType _typeToCount;
    [SerializeField] private Text _enemiesCountText;
    private int _enemiesCount;
    private SessionData _session;
    private void Awake()
    {
        _session = FindObjectOfType<SessionData>();
        _session.OnEnemyAdd += TryAddEnemiesCount;
        _session.OnEnemyRemove += TryRemoveEnemy;
    }
    public void UpdateEnemiesCount()
    {
        _enemiesCountText.text = _enemiesCount.ToString();
    }
    public void TryAddEnemiesCount(Creature enemy)
    {
        if (enemy.Color ==_typeToCount)
        {
            _enemiesCount++;
        }
        UpdateEnemiesCount();
    }
    public void TryRemoveEnemy(Creature enemy)
    {
        if (enemy.Color == _typeToCount)
        {
            _enemiesCount--;
        }
        UpdateEnemiesCount();
    }
}
