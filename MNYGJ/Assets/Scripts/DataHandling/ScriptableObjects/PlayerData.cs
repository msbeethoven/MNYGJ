using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New PlayerData", menuName = "PlayerData", order = 51)]
public class PlayerData : ScriptableObject
{
    [SerializeField]
    private string playerName;
    [SerializeField]
    private int playerMoney;
    [SerializeField]
    private int playerCurrentEnergy;
    [SerializeField]
    private int playerMaxEnergy;
    [SerializeField]
    private int playerExperience;
    [SerializeField]
    private int playerExperienceUntilNextLevel;
    [SerializeField]
    private int playerLevel;

    //todo: HOW DO MEASURE EXPERIENCE?!

    [SerializeField]
    private int daysPassed;

    //todo: calculate days from Moving to New York into an actual date


    public string PlayerName
    {
        get
        {
            return playerName;
        }
    }

    public int PlayerMoney
    {
        get
        {
            return playerMoney;
        }
    }

    public int PlayerCurrentEnergy
    {
        get
        {
            return playerCurrentEnergy;
        }
    }

    public int PlayerMaxEnergy
    {
        get
        {
            return playerMaxEnergy;
        }
    }

    public int PlayerExperience
    {
        get
        {
            return playerExperience;
        }
    }

    public int PlayerExperienceUntilNextLevel
    {
        get
        {
            return playerExperienceUntilNextLevel;
        }
    }

    public int DaysPassed
    {
        get
        {
            return daysPassed;
        }
    }

}