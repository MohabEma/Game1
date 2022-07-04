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

    void Start()
    {
        
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
    }

    void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
        Cursor.visible = false;
        UI.SetActive(false);
    }

    public void worldHub()
    {
        SceneManager.LoadScene(worldScene);
    }

    public void mainMenu()
    {
        SceneManager.LoadScene(menuScene);
    }

}
