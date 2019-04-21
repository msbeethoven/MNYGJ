using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class toggleObject : MonoBehaviour
{

   public GameObject minimapIcon;

   public GameObject agentPanel;
   public GameObject answerPanel;
   public GameObject buttonOverlay;



    // Start is called before the first frame update
    IEnumerator Start()
    {
        minimapIcon.SetActive(false);
        agentPanel.SetActive(false);
        answerPanel.SetActive(false);
        buttonOverlay.SetActive(false); 

        yield return loadObjects();
        // StartCoroutine("loadObjects"); 

    }

    IEnumerator loadObjects()
    {
      yield return new WaitForSeconds(1f);
      agentPanel.SetActive(true);
      yield return new WaitForSeconds(2f); 
      // agentPanel.SetActive(true); 
      answerPanel.SetActive(true); 
      yield return new WaitForSeconds(3f); 
      // answerPanel.SetActive(false);
      // agentPanel.SetActive(false);
      buttonOverlay.SetActive(true); 
    }


  

    
}


