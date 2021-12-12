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
    private bool _rShoulderHeld = false;


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

    public void OnShoot(CallbackContext context)
    {
        if (context.performed)
            _rShoulderHeld = true;

        else if (context.canceled)
            _rShoulderHeld = false;
            
      
            
         
    }

    private void Update()
    {
        if (_rShoulderHeld)
        {
            transform.GetChild(0).gameObject.GetComponent<WeaponDefault>().FireWeapon();
        }
      
    }
}
