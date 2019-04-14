using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerDataUI : MonoBehaviour
{
    [SerializeField]
    private PlayerData data;

    [SerializeField]
    private Text playerName;
    [SerializeField]
    private Text playerCurrentEnergy;
    [SerializeField]
    private Text playerMaxEnergy;
    [SerializeField]
    private Text playerMoney;
    [SerializeField]
    private Text playerExperience;
    [SerializeField]
    private Text playerExperienceUntilNextLevel;
    [SerializeField]
    private Text playerLevel;


    /*public void UpdateDisplayUI(PlayerData playerData)
    {

        playerName.text = playerData.PlayerName;
        playerCurrentEnergy.text = playerData.PlayerCurrentEnergy.ToString();
        playerMaxEnergy.text = playerData.PlayerMaxEnergy.ToString();
        playerMoney.text = playerData.PlayerMoney.ToString();
        playerExperience.text = playerData.PlayerExperience.ToString();
        playerExperience.text = playerData.PlayerExperienceUntilNextLevel.ToString();



    public void Update()
    {
        UpdateDisplayUI(data);

    }*/
}
