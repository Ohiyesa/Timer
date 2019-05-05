using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Lap : MonoBehaviour
{
    public Button lapBtn;
    public GameObject lapsInfo;
    public GameObject pauseImage;
    public Text lapText;
    public Text totalTime;
    public int lapNr = 0;
    private int totalTimeX;



    void Start(){
        AddListeners();
    }


    public void MakeInfoActive(){
        if(pauseImage.activeSelf){
            lapsInfo.SetActive(true);
        }
    }


    public void Laps(){
        if(pauseImage.activeSelf){
            lapNr ++;
            lapText.text += "#" + lapNr.ToString() + " -- "  + totalTime.text +
            "\n";
        }
    }


    public void AddListeners(){
        lapBtn.onClick.AddListener(() => MakeInfoActive());
        lapBtn.onClick.AddListener(() => Laps());
    }
}
