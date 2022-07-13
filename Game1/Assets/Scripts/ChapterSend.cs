using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ChapterSend : MonoBehaviour
{
    [Header("Scene Strings")]
    public string chapter1Scene;
    public string chapter2Scene;
    public string chapter3Scene;
    public string chapter4Scene;
    public string chapter5Scene;
    [Header("DLC Scene Strings")]
    public string dlcChapter0Scene;

    //Chapter 1 Scene Send
    public void chapter1()
    {
        SceneManager.LoadScene(chapter1Scene);
    }
    //Chapter 2 Scene Send
    public void chapter2()
    {
        SceneManager.LoadScene(chapter2Scene);
    }
    //Chapter 3 Scene Send
    public void chapter3()
    {
        SceneManager.LoadScene(chapter3Scene);
    }
    //Chapter 4 Scene Send
    public void chapter4()
    {
        SceneManager.LoadScene(chapter4Scene);
    }
    //Chapter 5 Scene Send
    public void chapter5()
    {
        SceneManager.LoadScene(chapter5Scene);
    }
    //DLC Chapter 0 Scene Send
    public void chapter0()
    {
        SceneManager.LoadScene(dlcChapter0Scene);
    }
}
