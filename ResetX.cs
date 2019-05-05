using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResetX : MonoBehaviour
{
    public Button resetButton;

    public GameObject lapInfo;
    public GameObject playImage;
    public GameObject pauseImage;
    public Text lapsText;

   
    void Start()
    {
        AddListener();
    }

    public void SetTozero(){
        GameObject.Find("Canvas Stop Watch").GetComponent<TimerTime>().totalTime = 0;
        playImage.SetActive(true);
        pauseImage.SetActive(false);
        lapsText.text = "";
        GameObject.Find("Lap").GetComponent<Lap>().lapNr = 0;
        lapInfo.SetActive(false);


    }

    void AddListener(){
        resetButton.onClick.AddListener(() => SetTozero());    
    }
  
}
