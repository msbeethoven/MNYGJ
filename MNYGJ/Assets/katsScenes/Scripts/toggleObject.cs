using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class toggleObject : MonoBehaviour
{
   public float delay = 1f; 
   public float delay2 =2f; 

   public float delay3 =4f; 
   public float delay4 = 5f; 
   public GameObject CharacterDialogue;
   public GameObject CustomizeAvatar; 


    // Start is called before the first frame update
    void Start()
    {
        CharacterDialogue.SetActive(false); 
        CustomizeAvatar.SetActive(true); 
    }

    // Update is called once per frame
   public void loadCutScene() {

    CharacterDialogue.SetActive(true); 
    CustomizeAvatar.SetActive(false); 
    CustomizeAvatar.SetActive(false); 
    CharacterDialogue.SetActive(true); 
    CharacterDialogue.transform.GetChild(2).gameObject.SetActive(false);
    CharacterDialogue.transform.GetChild(3).gameObject.SetActive(false); 
    CharacterDialogue.transform.GetChild(4).gameObject.SetActive(false); 
    CharacterDialogue.transform.GetChild(5).gameObject.SetActive(false); 

    StartCoroutine("loadObjects", delay); 
    StartCoroutine("loadObjects", delay2);
    StartCoroutine("loadObjects", delay3); 
    }
    IEnumerator loadObjects (float delay)
    {
      Debug.Log("started corouting loadObjects waiting for seconds:" + delay);
      yield return new WaitForSeconds(delay);
      Debug.Log("succesfully got past the wait for seconds");
      CharacterDialogue.transform.GetChild(2).gameObject.SetActive(true);
      yield return new WaitForSeconds(delay2); 
      CharacterDialogue.transform.GetChild(2).gameObject.SetActive(false); 
      CharacterDialogue.transform.GetChild(3).gameObject.SetActive(true); 
      yield return new WaitForSeconds(delay3); 
      CharacterDialogue.transform.GetChild(3).gameObject.SetActive(false);
      CharacterDialogue.transform.GetChild(4).gameObject.SetActive(true); 
      CharacterDialogue.transform.GetChild(5).gameObject.SetActive(true); 

    }
  

    
}


