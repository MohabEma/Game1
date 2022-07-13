using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool GameIsPaused = false;
    public GameObject pauseMenuUI;
    public GameObject UI;
    public string worldScene;
    public string menuScene;
    public GameObject hook;

    void Start()
    {
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.Confined;
        (GameIsPaused) = false;
    }
        
    void Update()
    {
        if (GameIsPaused)
        {
            
        }
        else
        {
            
        }

        if (Input.GetButtonDown("Pause"))
        {
            if (GameIsPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }

    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
        UI.SetActive(true);
        hook.SetActive(true);
    }

    void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
        UI.SetActive(false);
        hook.SetActive(false);
    }

    public void worldHub()
    {
        Resume();
        SceneManager.LoadScene(worldScene);
    }

    public void mainMenu()
    {
        Resume();
        SceneManager.LoadScene(menuScene);
    }

    public void quit()
    {
        Application.Quit();
    }
}
