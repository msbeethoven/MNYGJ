using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class enableApts : MonoBehaviour

{

    public GameObject obj1; 
    public GameObject obj2; 
    public GameObject obj3; 
    public GameObject obj4; 
    public GameObject obj5; 
    
    // Start is called before the first frame update
    void Start()
    {
        obj1.SetActive(true); 
        obj2.SetActive(false); 
        obj3.SetActive(false); 
        obj4.SetActive(false); 
        obj5.SetActive(false); 
    }

    // Update is called once per frame
    void Update()
    {



        if(Input.GetKeyDown(KeyCode.A)) {
                 obj2.SetActive(true); 

     }
     if(Input.GetKeyDown(KeyCode.B)) {
                 obj3.SetActive(true); 

     }
     if(Input.GetKeyDown(KeyCode.C)) {
                 obj4.SetActive(true); 

     }
     if(Input.GetKeyDown(KeyCode.D)) {
                 obj5.SetActive(true); 

     }
    }
}
