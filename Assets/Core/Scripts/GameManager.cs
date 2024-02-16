using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField] private float startTime;
    [SerializeField] private TextMeshProUGUI textTime;
    [SerializeField] private int countMatchs;
    
    private Item _selectItem;

    private void Update()
    {
        startTime -= Time.deltaTime;
        
        // Преобразуем секунды в формат "мм:сс"
        int minutes = Mathf.FloorToInt(startTime / 60);
        int remainingSeconds = Mathf.FloorToInt(startTime % 60);
        string formattedTime = string.Format("{0:00}:{1:00}", minutes, remainingSeconds);

        // Отображаем время в текстовом поле
        textTime.text = formattedTime;
        if (startTime <=0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }

        Application.targetFrameRate = 60;
    }

    public void SelectItem(Item item)
  {
    bool SelectTrue = false;
  
    
    if (_selectItem)
    {
       SelectTrue = _selectItem && _selectItem.index == item.index && _selectItem.gameObject != item.gameObject;
       if (_selectItem.index != item.index)
       {
           
        _selectItem.GetComponent<Image>().color = Color.white;
           _selectItem = item;
           _selectItem.GetComponent<Image>().color = Color.green;
       }
    }
    else
    {
       _selectItem = item;
       _selectItem.GetComponent<Image>().color = Color.green;
       
    }
    
   
    if (SelectTrue)
    {
      _selectItem.transform.DOScale(Vector3.zero, 0.5f);
      _selectItem = item;
      _selectItem.transform.DOScale(Vector3.zero, 0.5f);

      _selectItem = null;
      countMatchs--;
    }

    if (countMatchs == 0)
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

  }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void Back()
    {
        SceneManager.LoadScene(0);
    }
}
