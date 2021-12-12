using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //Analog stick vectors
    private Vector2 _leftStick;
    private Vector2 _rightStick;
    public float DeadZone = 0.1f;

    //Gameplay modifiers
    [SerializeField] private float movementSpeed;

    //Components
    [SerializeField] private Rigidbody rigidBody;


    private void FixedUpdate()
    {
        Move();
        Aim();
    }

    public void SetLeftStickVector(Vector2 direction)
    {
        _leftStick = direction;
    }

    public void SetRightStickVector(Vector2 direction)
    {
        _rightStick = direction;
        
    }

    private void Move() //Movement and aiming logic
    {
        rigidBody.velocity = new Vector3(_leftStick.x, 0, _leftStick.y) * movementSpeed;
    }

    private void Aim()
    {
        if(_rightStick.magnitude > deadZone)
            transform.rotation = Quaternion.LookRotation(new Vector3(_rightStick.x, 0, _rightStick.y));
    }
    
}
