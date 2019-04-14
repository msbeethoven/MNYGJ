using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class toggleAsset : MonoBehaviour
{
   public float count = 0; 
   public GameObject Man; 
   public GameObject Woman; 
   public GameObject Convo; 

   void Start() {
       Man.SetActive (false); 
       Woman.SetActive (false); 
       Convo.SetActive (false); 
   }

   void Update () {
       if (Time.time >= 3){
           Man.SetActive (true); 
       }
     if (Time.time >=5) {
           Woman.SetActive(true); 
       }
    if (Time.time >= 10) {
        Man.SetActive (false); 
        Woman.SetActive (false); 
        Convo.SetActive (true); 
   }
   }
}
