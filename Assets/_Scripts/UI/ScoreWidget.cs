using UnityEngine;
using UnityEngine.UI;

public class ScoreWidget : MonoBehaviour
{
    [SerializeField] private Text _scoresText;
    [SerializeField] private Text _maxScoresText;
    private int _currentScores;
    private int _maxScores;
    private SessionData _sessionData;
    private const float DEFAULT_SCORE = 100;
    private void Awake()
    {
        _sessionData = FindObjectOfType<SessionData>();
        _sessionData.OnEnemyRemove += AddScores;
        _maxScores = PlayerPrefs.GetInt("maxScores");
        UpdateScore();
    }
    public void AddScores(Creature creature)// костыль из-за нехватки времени
    {
        var scoresToAdd = Mathf.RoundToInt(DEFAULT_SCORE * _sessionData.Difficult);
        _currentScores += scoresToAdd;
        if (_currentScores > _maxScores) SetMaxScores(_currentScores);
        UpdateScore();
    }
    private void SetMaxScores(int value)
    {
        _maxScores = value;
    }
    public void SaveMaxScores()
    {
        PlayerPrefs.SetInt("maxScores", _maxScores);
        PlayerPrefs.Save();
    }
    private void UpdateScore()
    {
        _scoresText.text = _currentScores.ToString();
        _maxScoresText.text = _maxScores.ToString();
        SaveMaxScores();
    }

}
