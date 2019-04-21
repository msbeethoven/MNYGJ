using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 
using UnityEngine.SceneManagement; 


public class ButtonHandler : MonoBehaviour
{

    public GameObject minimapIcon;

    public void playBtn(){
        SceneManager.LoadScene("AvatarSelection"); 
    }

    public void leaveBtn(){
        Application.Quit(); 
    }

    public void loadGameMenu() {
        SceneManager.LoadScene("GameMenu");
    }

    public void loadAvatarSelection(){

        SceneManager.LoadScene("AvatarSelectionNEW"); 
    }

    public void loadMiniMapIcon() {
        minimapIcon.SetActive(true); 
    }

    public void loadMiniMap() {
        SceneManager.LoadScene("NYCMiniMap");
        // MiniMap.transform.GetChild(1).gameObject.SetActive(true); 
    }

    public void loadRunner() {

        SceneManager.LoadScene("Runner"); 
    }

    public void loadHome() {
        SceneManager.LoadScene("HomeScene"); 
    }

}
