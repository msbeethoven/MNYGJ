﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class translateCharacter : MonoBehaviour
{

    private Vector3 _startPosition;
    public float speed = 10f;
    // Start is called before the first frame update
    void Start()
    {
        _startPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.UpArrow))
        {
            transform.position = new Vector3(transform.position.x, transform.position.y + (Time.deltaTime * speed), transform.position.z);
            
        }

                if(Input.GetKeyDown(KeyCode.LeftArrow))
{
                transform.position = new Vector3(transform.position.x - (Time.deltaTime * speed), transform.position.y, transform.position.z);

}
         if(Input.GetKeyDown(KeyCode.RightArrow))
{
                transform.position = new Vector3(transform.position.x + (Time.deltaTime * speed), transform.position.y, transform.position.z);

}
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        transform.position = _startPosition;
    }
}
