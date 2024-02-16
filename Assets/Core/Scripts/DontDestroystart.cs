using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroystart : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if (FindObjectsOfType<DontDestroystart>().Length>1)
        {
            if (PlayerPrefs.GetInt("Volume")==1)
            {
                FindObjectOfType<AudioSource>().volume = 0;
            }
            Destroy(FindObjectsOfType<DontDestroystart>()[0].gameObject);
           return; 
        }
        DontDestroyOnLoad(gameObject);
        if (PlayerPrefs.GetInt("Volume")==1)
        {
            FindObjectOfType<AudioSource>().volume = 0;
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
