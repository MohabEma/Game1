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
    public string sceneDebug;
    [Header("Menu Settings")]
    public GameObject mainMenu;
    public GameObject optionsMenu;
    public GameObject extraMenu;

    public void start()
    {
        SceneManager.LoadScene(sceneStart);
    }

    public void options()
    {
        optionsMenu.SetActive(true);
        mainMenu.SetActive(false);
    }

    public void debug()
    {
        SceneManager.LoadScene(sceneDebug);
    }

    public void extra()
    {
        extraMenu.SetActive(true);
        mainMenu.SetActive(false);
    }

    public void backtomain()
    {
        mainMenu.SetActive(true);
        optionsMenu.SetActive(false);
        extraMenu.SetActive(false);
    }

    void Update()
    {
        versionNum.text = "V" + versionNum1.ToString() + "." + versionNum2.ToString() + "." + versionNum3.ToString();
    }
}
