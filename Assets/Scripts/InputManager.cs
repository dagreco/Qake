using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.InputSystem.InputAction;
using static UnityEngine.InputSystem.PlayerInputManager;

public class InputManager : MonoBehaviour
{
    private Movement movement;

    private void Awake()
    {
        movement = GetComponent<Movement>();
    }
    /*
    private void GetControllerInput() //Fetch controller input, for each player
    {
        lsInputVector = new Vector3(Input.GetAxis("X LS "+tag), 0, Input.GetAxis("Y LS "+tag)); // Tag is P1 for Player 1 OR P2 for Player 2

        if(lsInputVector.magnitude < inputDeadzone)
        {
            lsInputVector = Vector3.zero;
        }
    }
    */

    public void OnMove(CallbackContext context)
    {
        movement.SetLeftStickVector(context.ReadValue<Vector2>());
    }

    public void OnAim(CallbackContext context)
    {
        movement.SetRightStickVector(context.ReadValue<Vector2>());
    }

}
