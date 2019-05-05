using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AddFifteen : MonoBehaviour{
    public Button btn;
    

    void Start(){
        AddListeners();
    }
   
    public void AddFifteenFunction(){
        GameObject.Find("PlayPauseBtn").GetComponent<CountDown>().totalTime += 15f;
    }

    private void AddListeners(){
        btn.onClick.AddListener(() => AddFifteenFunction());
    }

    

   
}
