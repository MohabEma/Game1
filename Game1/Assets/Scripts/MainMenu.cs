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
    public string sceneCredits;
    public string sceneClicker;
    [Header("Menu Settings")]
    public GameObject mainMenu;
    public GameObject optionsMenu;
    public GameObject extraMenu;
    public GameObject conceptArt;
    public GameObject musicMenu;

    void Awake()
    {
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
        conceptArt.SetActive(false);
        musicMenu.SetActive(false);
    }

    public void concept()
    {
        conceptArt.SetActive(true);
        extraMenu.SetActive(false);
    }

    public void music()
    {
        musicMenu.SetActive(true);
        extraMenu.SetActive(false);
    }

    public void credit()
    {
        SceneManager.LoadScene(sceneCredits);
    }

    public void back()
    {
        extraMenu.SetActive(true);
        conceptArt.SetActive(false);
        musicMenu.SetActive(false);
    }

    void Update()
    {
        versionNum.text = "V" + versionNum1.ToString() + "." + versionNum2.ToString() + "." + versionNum3.ToString();
    }

    public void clicker()
    {
        SceneManager.LoadScene(sceneClicker);
    }
}
