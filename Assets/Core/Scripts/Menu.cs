using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    [SerializeField] private GameObject volumeOff, VibroOff;

    private void Start()
    {
        if (PlayerPrefs.GetInt("Volume" )== 0)
        {
            volumeOff.SetActive(false);
        }
        else
        {
            volumeOff.SetActive(true);
        }
        if (PlayerPrefs.GetInt("Vibro" )== 0)
        {
            VibroOff.SetActive(false);
        }
        else
        {
            VibroOff.SetActive(true);
        }
    }

    public void Volume()
    {
        if (PlayerPrefs.GetInt("Volume" )== 1)
        {
            PlayerPrefs.SetInt("Volume", 0);
            volumeOff.SetActive(false);
            FindObjectOfType<AudioSource>().volume = 1;
        }
        else
        {
            volumeOff.SetActive(true);
            PlayerPrefs.SetInt("Volume", 1);
            FindObjectOfType<AudioSource>().volume = 0;
        }
      
    }
    public void Vibro()
    {
        if (PlayerPrefs.GetInt("Vibro" )== 1)
        {
            PlayerPrefs.SetInt("Vibro", 0);
            VibroOff.SetActive(false);
   
        }
        else
        {
            VibroOff.SetActive(true);
            PlayerPrefs.SetInt("Vibro", 1);

        }

    }

    public void SelectLevel(int level)
    {
        PlayerPrefs.SetInt("Level", level);
        SceneManager.LoadScene(1);
    }
    public void Close()
    {
        Application.Quit();
    }
}
