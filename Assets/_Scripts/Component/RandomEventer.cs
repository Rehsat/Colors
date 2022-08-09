using UnityEngine;
using UnityEngine.Events;

public class RandomEventer : MonoBehaviour
{

    [SerializeField] [Range(0f, 100)] private float _probability;
    [SerializeField] private bool _scaleWithDifficult;

    [SerializeField] private UnityEvent _onSuccessEvent;
    [SerializeField] private UnityEvent _onFailEvent;

    private SessionData _sessionData;

    private void Awake()
    {
       _sessionData = FindObjectOfType<SessionData>();
    }
    public void TryInvokeEvent()
    {
        var probability = _probability;
        if(_scaleWithDifficult)
        {
            probability = _probability * _sessionData.Difficult;
        }
        var randomNumber = Random.Range(0, 100);

        if(probability > randomNumber)
        {
            _onSuccessEvent?.Invoke();
            return;
        }

        _onFailEvent?.Invoke();
    }    
}
