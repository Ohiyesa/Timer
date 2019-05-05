using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayANDPauseX : MonoBehaviour
{
    public GameObject playImage;
    public GameObject pauseImage;
    public Button mainBtn;

    void Update(){
        AddListeners();
    }

    public void PlayPauseSwitchON(){
        if(GameObject.Find("PlayPauseBtn").GetComponent<CountDown>().totalTime != 0){
            playImage.SetActive(false);
            pauseImage.SetActive(true);
        }
    }

    public void PlayPauseSwitchOFF(){
        playImage.SetActive(true);
        pauseImage.SetActive(false);
    }


    public void AddListeners(){
        while(playImage.activeSelf){
            mainBtn.onClick.AddListener(() => PlayPauseSwitchON());
            break;
        }
        while(pauseImage.activeSelf){
            mainBtn.onClick.AddListener(() => PlayPauseSwitchOFF());
            break;
        }
    }

}