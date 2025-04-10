using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using RootMotion.Demos;

public class LoadScene : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void SceneLoad()
    {
        SceneManager.LoadScene(0);
    }

    public void EndGame()
    {
        Application.Quit();
    }
}
