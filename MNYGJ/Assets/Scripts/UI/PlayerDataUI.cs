using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerDataUI : MonoBehaviour
{

    [SerializeField]
    private Text playerName;
    [SerializeField]
    private Text playerMoney;
    [SerializeField]
    private Text playerCurrentEnergy;
    [SerializeField]
    private Text playerMaxEnergy;
    [SerializeField]
    private Text playerExperience;
    [SerializeField]
    private Text playerExperienceUntilNextLevel;
    [SerializeField]
    private Text playerLevel;

    public void UpdateDisplayUI(PlayerData playerData)
    {
        playerName.text = playerData.PlayerName;
        playerMoney.text = playerData.PlayerMoney.ToString();
        playerCurrentEnergy.text = playerData.PlayerCurrentEnergy.ToString();
        playerMaxEnergy.text = playerData.PlayerMaxEnergy.ToString();
        playerExperience.text = playerData.PlayerExperience.ToString();
        playerExperience.text = playerData.PlayerExperienceUntilNextLevel.ToString();

    }
}
