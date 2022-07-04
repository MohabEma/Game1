using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ClickerSceneManage : MonoBehaviour
{
    [Header("Scene Name")]
    public string sceneMainMenu;

    public void mainmenu()
    {
        SceneManager.LoadScene(sceneMainMenu);
    }
    
}
