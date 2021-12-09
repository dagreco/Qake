using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //Components
    public Rigidbody playerRB; //Rigidbody of player, assigned in-editor
    
    //Controller inputs
    private float xAxis; //Left stick x axis (fetched in Update() and applied in FixedUpdate())
    private float yAxis; //Left stick y axis (fetched in Update() and applied in FixedUpdate())

    //Game modifiers
    


    void Start()
    {
        
    }

    void Update()
    {
        GetControllerInput();
        MovePlayer();
    }

    private void FixedUpdate()
    {
        
    }

    private void GetControllerInput() //Fetch controller input
    {
        xAxis = Input.GetAxis("X LS P1");
        yAxis = Input.GetAxis("Y LS P1");
    }

    private void MovePlayer()
    {

    }
}
