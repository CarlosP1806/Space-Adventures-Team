using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Navigation : MonoBehaviour
{
    public static string currentScene = "";

    public void GoToLevelSelection()
    {
        currentScene = "Level Selection";
        UnityEngine.SceneManagement.SceneManager.LoadScene("Level Selection");
    }

    public void GoToLevel1()
    {
        currentScene = "Level1";
        UnityEngine.SceneManagement.SceneManager.LoadScene("Level1");
    }

    public void GoToLevel2()
    {
        currentScene = "Level2";
        UnityEngine.SceneManagement.SceneManager.LoadScene("Level2");
    }

    public void GoToLevel3()
    {
        currentScene = "Level3";
        UnityEngine.SceneManagement.SceneManager.LoadScene("Level3");
    }

    public void GoToMenu()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Main Menu");
    }

    public void GoToLogIn()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("LogIn-Menu");
    }

    public void Pause()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Pause");
    }

    public void ResumeGame()
    {
        if (currentScene != "")
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene(currentScene);
        }
        else
        {
            Debug.LogWarning("No se ha almacenado un nombre de escena válido antes de intentar resumir el juego.");
        }
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
