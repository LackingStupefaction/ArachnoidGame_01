using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class StartMenu : MonoBehaviour
{
    public void QuitGame()
    {
        Application.Quit();
        Debug.Log ("Don't leave, drones need you.");
    }

    public void StartGame()
    {
        SceneManager.LoadScene("Level1");
    }

}