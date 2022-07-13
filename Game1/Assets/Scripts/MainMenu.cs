using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class MainMenu : MonoBehaviour
{
    [Header("Version Display")]
    public int versionNum1;
    public int versionNum2;
    public int versionNum3;
    public TextMeshProUGUI versionNum;
    [Header("Scene Direct")]
    public string sceneStart;
    public string sceneContinue;
    public string sceneDebug;
    public string sceneCredits;
    public string sceneClicker;
    public string sceneEditor;
    [Header("Menu Settings")]
    public GameObject mainMenu;
    public GameObject optionsMenu;
    public GameObject restartMenu;

    void Awake()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    public void start()
    {
        SceneManager.LoadScene(sceneStart);
    }

    public void options()
    {
        optionsMenu.SetActive(true);
        mainMenu.SetActive(false);
    }

    public void contin()
    {
        SceneManager.LoadScene(sceneContinue);
    }

    public void debug()
    {
        SceneManager.LoadScene(sceneDebug);
    }

    public void backtomain()
    {
        mainMenu.SetActive(true);
        optionsMenu.SetActive(false);
        restartMenu.SetActive(false);
    }

    public void credit()
    {
        SceneManager.LoadScene(sceneCredits);
    }

    void Update()
    {
        versionNum.text = "V" + versionNum1.ToString() + "." + versionNum2.ToString() + "." + versionNum3.ToString();
    }

    public void clicker()
    {
        SceneManager.LoadScene(sceneClicker);
    }

    public void editor()
    {
        SceneManager.LoadScene(sceneEditor);
    }
}
