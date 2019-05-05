using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class canvas_switch_button : MonoBehaviour
{
   public Canvas TimerCanvas;
   public Button TimerIconBorder;

   public Canvas StopWatchCanvas;
   public Button StopWatchIconBorder;



   public void IconClick()
   {
       TimerCanvas.gameObject.SetActive(true);
       StopWatchCanvas.gameObject.SetActive(false);
   }

    public void IconClick2()
   {
       StopWatchCanvas.gameObject.SetActive(true);
       TimerCanvas.gameObject.SetActive(false);
       

   }
}
