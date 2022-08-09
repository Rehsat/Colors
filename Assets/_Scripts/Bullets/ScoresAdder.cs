using UnityEngine;

public class ScoresAdder : MonoBehaviour
{
    private const float DEFAULT_SCORE = 100;
    private SessionData _sessionData;

    private void Awake()
    {
        _sessionData = FindObjectOfType<SessionData>();
    }
    public void AddScores()
    {
        var scoresToAdd = Mathf.RoundToInt(DEFAULT_SCORE * _sessionData.Difficult);
    }
}
