using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Reset : MonoBehaviour
{
    public Button resetButton;
    public GameObject playImage;
    public GameObject pauseImage;

   
    void Start()
    {
        AddListener();
    }


    public void SetTozero(){
        GameObject.Find("PlayPauseBtn").GetComponent<CountDown>().totalTime = 0;
        playImage.SetActive(true);
        pauseImage.SetActive(false);
        
    }


    void AddListener(){
        resetButton.onClick.AddListener(() => SetTozero());    
    }
  
}
