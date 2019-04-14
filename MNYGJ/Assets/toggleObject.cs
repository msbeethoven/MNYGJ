using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class toggleObject : MonoBehaviour
{
   public float delay = 3f; 
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
    
    StartCoroutine("loadObjects", delay); 
    }
    IEnumerator loadObjects (float delay)
    {
      Debug.Log("started corouting loadObjects waiting for seconds:" + delay);
      yield return new WaitForSeconds(delay);
      Debug.Log("succesfully got past the wait for seconds");
      CharacterDialogue.transform.GetChild(2).gameObject.SetActive(true);
     
    }
}


