using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class disableObject : MonoBehaviour

{
    public GameObject mapIcon; 
    // Start is called before the first frame update
    void Start()
    {
        mapIcon.SetActive(false); 
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
