using UnityEngine;
using UnityEngine.UI;
public class TimerTime : MonoBehaviour
{
    public GameObject pauseImage;
    public GameObject playImage;

   

    public float totalTime;
    float pauseTime;
    public Text timer;
    float x;



 
    private void Update(){
        UpdateLevelTimer(totalTime);
        timerX(pauseTime);
    }

        public void timerX(float x){
       
        while(playImage.activeSelf){
            
            int totalMinutes = Mathf.FloorToInt(x / 60f);
            int minutes = totalMinutes % 60; 
            int seconds = Mathf.RoundToInt(x % 60f);
            int hours = Mathf.FloorToInt(x / 3600f);

            pauseTime = totalTime;
            
            timer.text = minutes.ToString("00") + ":" + seconds.ToString("00");

            if (seconds >= 60){
                seconds = 0;
                minutes += 1;
            }

            if (minutes >= 60){
                minutes = 0;
                hours++;
            }

            while(hours >= 1){
                timer.text = hours.ToString("00") + ":" + minutes.ToString("00") + ":" + seconds.ToString("00");
                break;
            }

            break;
        }
    }


    public void UpdateLevelTimer(float totalSeconds){
            
            while(pauseImage.activeSelf){
                totalTime += Time.deltaTime;

                int totalMinutes = Mathf.FloorToInt(totalSeconds / 60f);
                int minutes = totalMinutes % 60;     
                int seconds = Mathf.RoundToInt(totalSeconds % 60f);
                int hours = Mathf.FloorToInt(totalSeconds / 3600f);

        
                string formatedSeconds = seconds.ToString();

                timer.text = minutes.ToString("00") + ":" + seconds.ToString("00");
        
                if (seconds >= 60){
                    seconds = 0;
                    minutes += 1;
                }
        
                if(minutes >= 60){
                minutes = 0;
                hours++;
                }

                
                while(hours >= 1){
                    timer.text = hours.ToString("00") + ":" + minutes.ToString("00") + ":" + seconds.ToString("00");
                    break;
                }

            break;
            }
    }
}
