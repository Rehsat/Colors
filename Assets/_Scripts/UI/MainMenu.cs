using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    public void OnStart(int id)
    {
        SceneManager.LoadScene(id);
    }
    public void OnOptions()
    {

    }
    public void OnQuit()
    {
        Application.Quit();
    }
}
