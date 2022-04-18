using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool IsGamePause = false;
    public GameObject PauseMenuUI;
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if (IsGamePause)
                Resume();
            else
                Pause();
        }
    }

    public void Resume()
    {
        PauseMenuUI.SetActive(false);
        Time.timeScale = 1;
        IsGamePause = false;
    }

    public void Restart()
    {
        PauseMenuUI.SetActive(false);
        Time.timeScale = 1;
        IsGamePause = false;
        SceneManager.LoadScene("Pixels");
    }

    public void Pause()
    {
        PauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        IsGamePause = true;
    }

    public void MainMenu()
    {
        Debug.Log("Main Menu");
        SceneManager.LoadScene("Main menu");
    }
}
