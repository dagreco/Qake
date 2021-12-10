using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    //Analog stick vectors
    private Vector2 leftStick;
    private Vector2 rightStick;

    //Gameplay modifiers
    [SerializeField] private float movementSpeed;

    //Components
    [SerializeField] private Rigidbody rigidBody;


    private void FixedUpdate()
    {
        Move();
    }

    public void SetLeftStickVector(Vector2 direction)
    {
        leftStick = direction;
    }

    public void SetRightStickVector(Vector2 direction)
    {
        rightStick = direction;
    }

    private void Move() //Movement logic
    {
        rigidBody.velocity = new Vector3(leftStick.x, 0, leftStick.y) * movementSpeed;
    }
}
