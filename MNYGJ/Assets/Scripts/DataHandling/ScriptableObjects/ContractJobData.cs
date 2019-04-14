using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New ContractJobData", menuName = "ContractJob", order = 52)]
public class ContractJobData : ScriptableObject
{
    [SerializeField]
    private string contractJobName;

    //this job is available only once the player is at this level 
    [SerializeField]
    private int levelAvailable;

    //how many experience points will this job add to the player's experience?
    [SerializeField]
    private int experiencePoints;

    //how much money will the job add to the player's bank? 
    [SerializeField]
    private int dailySalary;

    //how many hours of the day does this job take up ? 
    [SerializeField]
    private int jobDurationInHours;

    //if the player does not successfully get through the crossy-road map in 'time' 
    //(ex. can only be hit twice before they're 'late')
    //this is how much each 'hit' deducts from the daily salary
    [SerializeField]
    private int latenessFee;

    //contractJobPayout = dailySalary - (latenessFee * (number of hits from crossy-road))
    //[SerializeField]
    //private int contractJobPayout; 

    //todo: calculate actual payout

    public string ContractJobName
    {
        get
        {
            return contractJobName;
        }
    }

    public int LevelAvailable
    {
        get
        {
            return levelAvailable;
        }
    }

    public int ExperiencePoints
    {
        get
        {
            return experiencePoints;
        }
    }

    public int DailySalary
    {
        get
        {
            return dailySalary;
        }
    }

    public int JobDurationInHours
    {
        get
        {
            return jobDurationInHours;
        }
    }

    public int LatenessFee
    {
        get
        {
            return latenessFee;
        }
    }
}
