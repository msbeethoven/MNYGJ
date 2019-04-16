using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class turnOn : MonoBehaviour
{

   public GameObject Congrats;
   public GameObject Money; 
   void Start() {
       Congrats.SetActive(false); 
       Money.SetActive(false); 
   }
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Congrats.SetActive(true); 
            
        }

        if(Input.GetKeyDown(KeyCode.M))
        {
            Money.SetActive(true); 
            Congrats.SetActive(false); 
        }
        
    }
}
