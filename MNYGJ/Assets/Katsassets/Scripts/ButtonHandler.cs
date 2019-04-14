using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 
using UnityEngine.SceneManagement; 

public class ButtonHandler : MonoBehaviour
{
public void playBtn(){
    SceneManager.LoadScene("AvatarSelection"); 
}

public void leaveBtn(){
    Application.Quit(); 
    Debug.Log("Quit Application");
}

public void loadCutScene() {

    SceneManager.LoadScene("IntroCutScene"); 
}

public void loadAvatarSelection(){
    
    SceneManager.LoadScene("AvatarSelection"); 
}

public void loadMiniMap() {

    SceneManager.LoadScene("MiniMap"); 

}

public void loadRunner() {

    SceneManager.LoadScene("Runner"); 
}
}
