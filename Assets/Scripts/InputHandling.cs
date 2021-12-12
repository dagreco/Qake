using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using static UnityEngine.InputSystem.InputAction;
using static UnityEngine.InputSystem.PlayerInputManager;

public class InputHandling : MonoBehaviour
{
    private PlayerController _movement;


    private void Awake()
    {
        _movement = GetComponent<PlayerController>();
    }

    public void OnMove(CallbackContext context)
    {
        _movement.SetLeftStickVector(context.ReadValue<Vector2>());
    }

    public void OnAim(CallbackContext context)
    {
        _movement.SetRightStickVector(context.ReadValue<Vector2>());
    }

}
