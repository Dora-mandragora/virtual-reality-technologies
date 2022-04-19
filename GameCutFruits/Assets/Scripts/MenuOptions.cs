using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuOptions : MonoBehaviour
{
    public static bool IsGamePause = false;
    public GameObject PauseMenuUI;
    // Update is called once per frame
    void Update()
    {
        //либо разделить логику ESC, либо на разные кнопки сразу вешать другие действия (без учета ESC)
        //а то при каждом нажатии ESC возникает фигня всякая
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
        SceneManager.LoadScene("Game");
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
