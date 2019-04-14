using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RunnerObstacle : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //if collided with the PlayerCharacter
        if (collision.gameObject.GetComponent<PlayerJump>() != null)
        {
            //todo: 
            //subtract the number of times allowed to get hit 
            //before deductions happen
            //trigger some kind of animation for the player character?
        }
    }
    /*
{

    if(other.GetComponent<PlayerJump>() != null)
    {
         
    }
}*/
}
