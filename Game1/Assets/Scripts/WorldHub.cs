using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class WorldHub : MonoBehaviour
{
    public GameObject Pause;
    public GameObject ui;
    public Animator uiAni;

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Pause.SetActive(false);
            ui.SetActive(true);
        }
    }

    public void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Pause.SetActive(true);
            ui.SetActive(false);
        }
    }
}
