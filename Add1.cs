using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Add1 : MonoBehaviour{
    public Button btn;
    

    void Start(){
        AddListeners();
    }
   
    public void Add1Function(){
        GameObject.Find("PlayPauseBtn").GetComponent<CountDown>().totalTime += 60f;
    }

    private void AddListeners(){
        btn.onClick.AddListener(() => Add1Function());
    }

    

   
}
