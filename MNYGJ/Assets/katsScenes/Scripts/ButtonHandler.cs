using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 
using UnityEngine.SceneManagement; 


public class ButtonHandler : MonoBehaviour
{
    public GameObject MiniMap; 


public void playBtn(){
    SceneManager.LoadScene("AvatarSelection"); 
}

public void leaveBtn(){
    Application.Quit(); 
    Debug.Log("Quit Application");
}

public void loadGameMenu() {
    SceneManager.LoadScene("GameMenu");
}




public void loadAvatarSelection(){
    
    SceneManager.LoadScene("AvatarSelection"); 
    
}

public void loadMiniMapIcon() {

    
    MiniMap.transform.GetChild(0).gameObject.SetActive(true); 


}

public void loadMiniMap() {

    Debug.Log("Mini Map Working");
    MiniMap.transform.GetChild(1).gameObject.SetActive(true); 
}

public void loadRunner() {

    SceneManager.LoadScene("Runner"); 
}
}
