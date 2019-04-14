using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class loadFill : MonoBehaviour
{
   public Image progress;

    // Update is called once per frame
    void Update () 
    {
            progress.fillAmount -=  Time.deltaTime;
    }
}
