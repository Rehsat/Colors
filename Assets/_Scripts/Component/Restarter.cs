using UnityEngine.SceneManagement;
using UnityEngine;

public class Restarter : MonoBehaviour
{
    [SerializeField] private PlayerActions _input;
    private void Awake()
    {
        _input = new PlayerActions();
        _input.Enable();

        _input.PlayerMap.Restart.performed += ctx => Restart();
    }
    private void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
