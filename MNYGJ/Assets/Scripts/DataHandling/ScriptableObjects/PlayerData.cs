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
        set
        {
            playerName = value;
        }
    }

    public int PlayerMoney
    {
        get
        {
            return playerMoney;
        }
        set
        {
            playerMoney = value;
        }
    }

    public int PlayerCurrentEnergy
    {
        get
        {
            return playerCurrentEnergy;
        }
        set
        {
            playerCurrentEnergy = value;
        }
    }

    public int PlayerMaxEnergy
    {
        get
        {
            return playerMaxEnergy;
        }
        set
        {
            playerMaxEnergy = value;
        }
    }

    public int PlayerExperience
    {
        get
        {
            return playerExperience;
        }
        set 
        {
            playerExperience = value;
        }
    }

    public int PlayerExperienceUntilNextLevel
    {
        get
        {
            return playerExperienceUntilNextLevel;
        }
        set
        {
            playerExperienceUntilNextLevel = value;
        }
    }

    public int DaysPassed
    {
        get
        {
            return daysPassed;
        }
        set
        {
            daysPassed = value;
        }
    }

}