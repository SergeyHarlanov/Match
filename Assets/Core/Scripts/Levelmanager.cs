using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Levelmanager : MonoBehaviour
{
    [SerializeField] private GameObject[] levels;

    private void Start()
    {
        levels[PlayerPrefs.GetInt("Level")].SetActive(true);
    }
}
