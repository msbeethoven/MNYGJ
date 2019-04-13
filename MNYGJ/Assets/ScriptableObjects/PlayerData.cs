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
    private int playerEnergy;
    [SerializeField]
    private int playerExperience;
    [SerializeField]
    private int daysPassed;

    //todo: calculate days from Moving to New York into an actual date
}
