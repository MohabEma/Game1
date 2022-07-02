using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    public int health;
    public int numOfHearts;
    public Animator animator;
    public Image[] hearts;
    public Sprite fullHeart;
    public Sprite emptyHeart;

    [SerializeField] private Transform Player;
    [SerializeField] private Transform RespawnPoint;

    public void Update()
    {
        if(health == 0)
        {
            StartCoroutine(Deathe());
        }

        if (Input.GetKeyDown(KeyCode.K))
        {
            health = health - 1;
        }

        if (health > numOfHearts)
        {
            health = numOfHearts;
        }
        for (int i = 0; i < hearts.Length; i++)
        {
            if (i < health)
            {
                hearts[i].sprite = fullHeart;
            }
            else
            {
                hearts[i].sprite = emptyHeart;
            }
            if(i < numOfHearts)
            {
                hearts[i].enabled = true;
            }
            else
            {
                hearts[i].enabled = false;
            }
        }
    }

    IEnumerator Deathe()
    {

        animator.SetBool("Death", true);
        
        yield return new WaitForSeconds(0.7f);

        health = health + 3;
        Player.transform.position = RespawnPoint.transform.position;
        

        animator.SetBool("Death", false);

       





    }

}
