using UnityEngine;
using UnityEngine.UI;
public class CountDown : MonoBehaviour
{
    public GameObject pauseImage;
    public GameObject playImage;

   

    public float totalTime = 0f;
    float pauseTime;
    public Text timer;
    float x;
    float y;


 
    private void Update(){
        UpdateLevelTimer(totalTime);
        timerX(pauseTime);
    }


    public void timerX(float x){
        

        int totalMinutes = Mathf.FloorToInt(x / 60f);
        int minutes = totalMinutes % 60; 
        int seconds = Mathf.RoundToInt(x % 60f);
        int hours = Mathf.FloorToInt(x / 3600f);

        pauseTime = totalTime;

        while(playImage.activeSelf){
            
            timer.text = minutes.ToString("00") + ":" + seconds.ToString("00");

            if (seconds >= 60){
                seconds = 0;
                minutes += 1;
            }

            if (minutes >= 60){
                minutes = 0;
                hours += 1;
            }

            while(hours >= 1){
                timer.text = hours.ToString("00") + ":" + minutes.ToString("00") + ":" + seconds.ToString("00");
                break;
            }

            break;
        }
    }
 


    public void UpdateLevelTimer(float totalSeconds){

        if(totalTime != 0f){
            
            while(pauseImage.activeSelf){
                
                totalTime -= Time.deltaTime;

                int totalMinutes = Mathf.FloorToInt(totalSeconds / 60f);
                int minutes = totalMinutes % 60; 
                int seconds = Mathf.RoundToInt(totalSeconds % 60f);
                int hours = Mathf.FloorToInt(totalSeconds / 3600f);

                if(minutes == 0 && seconds == 0){
                playImage.SetActive(true);
                pauseImage.SetActive(false);
                }
        
                string formatedSeconds = seconds.ToString();

                timer.text = minutes.ToString("00") + ":" + seconds.ToString("00");
        
                if (seconds >= 60){
                    seconds = 0;
                    minutes += 1;
                }

        
                if (minutes >= 60){
                    minutes = 0;
                    hours += 1;
                }

                
                while(hours >= 1){
                    timer.text = hours.ToString("00") + ":" + minutes.ToString("00") + ":" + seconds.ToString("00");
                break;
                }

            break;
            }
        }
    } 

 

}
