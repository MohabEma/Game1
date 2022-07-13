using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DoorScript : MonoBehaviour
{
    public GameObject noti;
    public string nextScene;
    public bool colliding;

    //On Collider Enter, It Will Allow The Player To Enter The Next Area
    public void OnTriggerEnter2D(Collider2D Player)
    {
        noti.SetActive(true);
        colliding = true;
    }

    //On Collider Exit, It Will Stop Player From Entering Next Area
    public void OnTriggerExit2D(Collider2D Player)
    {
        noti.SetActive(false);
        colliding = false;
    }

    public void sceneChange()
    {
        SceneManager.LoadScene(nextScene);
    }

    void Update()
    {
        if(colliding && Input.GetButtonDown("Enter"))
        {
            sceneChange();
        }
    }
}
