﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scroller : MonoBehaviour
{

    private Rigidbody2D rb2d;
    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        rb2d.velocity = new Vector2 (0, PlayerJump.instance.scrollSpeed);
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerJump.instance.gameOver == true){
            rb2d.velocity = Vector2.zero;
            
        }
        
    }
}
