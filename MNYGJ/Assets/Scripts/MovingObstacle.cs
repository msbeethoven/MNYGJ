using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingObstacle : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        //if collided with the PlayerCharacter
        if(other.GetComponent<PlayerJump>() != null)
        {
            //todo: 
            //subtract the number of times allowed to get hit 
            //before deductions happen
            //trigger some kind of animation? 
        }
    }
}
