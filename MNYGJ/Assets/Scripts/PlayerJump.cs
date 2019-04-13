using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJump : MonoBehaviour
{

    public float jumpForce = 400f; 
    private bool isJumping = false;
    private Rigidbody2D rigidbody;
    // Start is called before the first frame update
    private void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    private void Update()
    {
        if (!isJumping) {
            isJumping = Input.GetButtonDown("Jump");
        }
        
    }

    private void FixedUpdate(){

        if(isJumping){
            rigidbody.AddForce(new Vector2(0f, jumpForce));
            isJumping = false;
        }
    }
}
