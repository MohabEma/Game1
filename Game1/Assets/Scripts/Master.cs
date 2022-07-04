using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Master : MonoBehaviour
{
    public TMP_Text ui;
    public TMP_Text text;
    public int spc;
    public void Increment()
    {
        GameManager.o2 += GameManager.multiplier;
        PlayerPrefs.SetInt("o2", GameManager.o2);
        PlayerPrefs.SetInt("cps", spc);
    }

    public void Buy(int num)
    {
        if (num == 1 && GameManager.o2 >= 100)
        {
            GameManager.multiplier += 1;
            spc += 1;
            GameManager.o2 -= 100;
            PlayerPrefs.SetInt("o2", GameManager.o2);
            PlayerPrefs.SetInt("cps", spc);
            PlayerPrefs.SetInt("multiplier", GameManager.multiplier);
        }
        if (num == 2 && GameManager.o2 >= 250)
        {
            GameManager.multiplier += 3;
            spc += 3;
            GameManager.o2 -= 250;
            PlayerPrefs.SetInt("o2", GameManager.o2);
            PlayerPrefs.SetInt("cps", spc);
            PlayerPrefs.SetInt("multiplier", GameManager.multiplier);
        }
        if (num == 3 && GameManager.o2 >= 500)
        {
            GameManager.multiplier += 10;
            spc += 10;
            GameManager.o2 -= 500;
            PlayerPrefs.SetInt("o2", GameManager.o2);
            PlayerPrefs.SetInt("cps", spc);
            PlayerPrefs.SetInt("multiplier", GameManager.multiplier);
        }
        if (num == 4 && GameManager.o2 >= 700)
        {
            GameManager.multiplier += 15;
            spc += 15;
            GameManager.o2 -= 700;
            PlayerPrefs.SetInt("o2", GameManager.o2);
            PlayerPrefs.SetInt("cps", spc);
            PlayerPrefs.SetInt("multiplier", GameManager.multiplier);
        }
        if (num == 5 && GameManager.o2 >= 1100)
        {
            GameManager.multiplier += 20;
            spc += 20;
            GameManager.o2 -= 1100;
            PlayerPrefs.SetInt("o2", GameManager.o2);
            PlayerPrefs.SetInt("cps", spc);
            PlayerPrefs.SetInt("multiplier", GameManager.multiplier);
        }
        if (num == 6 && GameManager.o2 >= 1500)
        {
            GameManager.multiplier += 30;
            spc += 30;
            GameManager.o2 -= 1500;
            PlayerPrefs.SetInt("o2", GameManager.o2);
            PlayerPrefs.SetInt("cps", spc);
            PlayerPrefs.SetInt("multiplier", GameManager.multiplier);
        }
        if (num == 7 && GameManager.o2 >= 1750)
        {
            GameManager.multiplier += 35;
            spc += 35;
            GameManager.o2 -= 1750;
            PlayerPrefs.SetInt("o2", GameManager.o2);
            PlayerPrefs.SetInt("cps", spc);
            PlayerPrefs.SetInt("multiplier", GameManager.multiplier);
        }
        if (num == 8 && GameManager.o2 >= 2000)
        {
            GameManager.multiplier += 45;
            spc += 45;
            GameManager.o2 -= 2000;
            PlayerPrefs.SetInt("o2", GameManager.o2);
            PlayerPrefs.SetInt("cps", spc);
            PlayerPrefs.SetInt("multiplier", GameManager.multiplier);
        }
        if (num == 12 && GameManager.o2 >= 10000)
        {
            GameManager.multiplier += 450;
            spc += 450;
            GameManager.o2 -= 10000;
            PlayerPrefs.SetInt("o2", GameManager.o2);
            PlayerPrefs.SetInt("cps", spc);
            PlayerPrefs.SetInt("multiplier", GameManager.multiplier);
        }
        if (num == 9 && GameManager.o2 >= 2500)
        {
            GameManager.multiplier += 75;
            spc += 75;
            GameManager.o2 -= 2500;
            PlayerPrefs.SetInt("o2", GameManager.o2);
            PlayerPrefs.SetInt("cps", spc);
            PlayerPrefs.SetInt("multiplier", GameManager.multiplier);
        }
        if (num == 10 && GameManager.o2 >= 5000)
        {
            GameManager.multiplier += 200;
            spc += 200;
            GameManager.o2 -= 5000;
            PlayerPrefs.SetInt("o2", GameManager.o2);
            PlayerPrefs.SetInt("cps", spc);
            PlayerPrefs.SetInt("multiplier", GameManager.multiplier);
        }
        if (num == 11 && GameManager.o2 >= 7500)
        {
            GameManager.multiplier += 300;
            spc += 300;
            GameManager.o2 -= 7500;
            PlayerPrefs.SetInt("o2", GameManager.o2);
            PlayerPrefs.SetInt("cps", spc);
            PlayerPrefs.SetInt("multiplier", GameManager.multiplier);
        }
    }
    void Update()
    {
        ui.text = "Squishes: " + GameManager.o2 + "";
        text.text = "SPC: " + spc.ToString();
    }

    public void deleteProgress()
    {
        PlayerPrefs.DeleteAll();
        SceneManager.LoadScene("Menu");
    }
}

