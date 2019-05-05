using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AlarmSound : MonoBehaviour
{
    public GameObject pauseImage;
    public GameObject playImage;
    public AudioSource alarmSound;

  

    void Update(){
        SoundoOn();
        SoundoOff();
    }
    
    
    public void SoundoOn(){
        while(pauseImage.activeSelf & GameObject.Find("PlayPauseBtn").GetComponent<CountDown>().totalTime < 1f){
            alarmSound.gameObject.SetActive(true);
            break;
        }
    }

    public void SoundoOff(){
        while(playImage.activeSelf){ 
            alarmSound.gameObject.SetActive(false);
            break;
        }
    }
}
