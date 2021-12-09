using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //Components
    public Rigidbody playerRB;
    
    //Controller values
    private Vector3 lsInputVector; //Left stick input as vector3
    public float inputDeadzone;

    //Game modifiers
    public float moveSpeed;
  

    void Start()
    {
        
    }

    void Update()
    {
        GetControllerInput();
        
    }

    private void FixedUpdate()
    {
        MovePlayer();
        Debug.Log(playerRB.velocity);
    }

    private void GetControllerInput() //Fetch controller input, for each player
    {
        lsInputVector = new Vector3(Input.GetAxis("X LS "+tag), 0, Input.GetAxis("Y LS "+tag)); // Tag is P1 for Player 1 OR P2 for Player 2

        if(lsInputVector.magnitude < inputDeadzone)
        {
            lsInputVector = Vector3.zero;
        }
    }

    private void MovePlayer() //Does whats on the tin
    {
        playerRB.velocity = lsInputVector*moveSpeed;
    }
}
