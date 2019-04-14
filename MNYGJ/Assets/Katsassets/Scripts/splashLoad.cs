using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class splashLoad : MonoBehaviour
{
    public float delay = 5; 
    public string GameMenu = "GameMenu"; 
    // Start is called before the first frame update
    void Start()
    {
       StartCoroutine(LoadLevelAfterDelay(delay)); 

    }

    IEnumerator LoadLevelAfterDelay (float delay)
    {
        yield return new WaitForSeconds(delay);
        SceneManager.LoadScene(GameMenu); 
    }
}
