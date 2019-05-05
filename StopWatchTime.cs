using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StopWatchTime : MonoBehaviour
{
    public Text timerText;
    public Button mainButton;
    public GameObject pauseImage;
    public GameObject playImage;

    private float secondsCountTotal;
    private float secondsCount;
    private int minuteCount;
    private int hourCount;

    private string zero1 = "";
    private string zero2 = "";
    private string zero3 = "0";

 
    
    void Update(){
        StartStopWatch();
    }
   
    
    public void StartStopWatch(){
        while(pauseImage.activeSelf){
            
            secondsCount += Time.deltaTime;
            timerText.text =zero2 + minuteCount + ":" + zero1 + (int)secondsCount;


            //-----------------REMOVING AND ADDING THE ZERO-------------------
            while (secondsCount <10){
                zero1 = "0";
            break;
            }

            while (secondsCount >=10){
                    zero1 = "";
                    break;
            }

            while (minuteCount <10){
                zero2 = "0";
                break;
            }

            while (minuteCount >=10){
                zero2 = "";
                break;
            }

            while(hourCount >= 10){
                zero3 = "";
                break;
            }
            


                //------ADDING: MINUTES AND HOURS------------------------
            if(secondsCount >= 60){
                minuteCount++;
                secondsCount = 0;
            }


            if(minuteCount >= 60){
                hourCount++;
                minuteCount = 0;
            }
                
            if(hourCount >= 1){
                timerText.text =zero3 + hourCount + ":" + zero2 + minuteCount + ":" + zero1 + (int)secondsCount;
            }

            break;
        }
    }    
}

            
      

        
