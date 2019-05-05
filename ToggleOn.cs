using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToggleOn : MonoBehaviour
{
    public Button ToggleOnButton;
    public GameObject DisabledImage;
    public GameObject EnabledImage;
    

    public void ToggleOnClickFunction()
    { 
        DisabledImage.SetActive(false);
        EnabledImage.SetActive(true);
    }


       public void ToggleOffClickFunction2()
    { 
        DisabledImage.SetActive(true);
        EnabledImage.SetActive(false);
    }



    


}
