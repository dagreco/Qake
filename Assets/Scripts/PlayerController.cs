using System;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //Analog stick vectors
    [HideInInspector] public Vector2 _leftStick;
    [HideInInspector] public Vector2 _rightStick;

    //Button bools
    [HideInInspector] public bool RightShoulderPressed;

    //Gameplay modifiers
    [SerializeField] private float movementSpeed;

    //Components
    private Rigidbody rigidBody;

    private Inventory inventory; 

    private void Awake()
    {
        rigidBody = GetComponent<Rigidbody>();
        inventory = GetComponent<Inventory>();
    }

    private void FixedUpdate()
    {
        Move();
        Aim();
    }
    private void Update()
    {
        if (RightShoulderPressed)
            Shoot();
    }

    private void Drop()
    {
        throw new NotImplementedException();
    }

    private void Move() //Movement logic
    {
        rigidBody.velocity = new Vector3(_leftStick.x, 0, _leftStick.y) * movementSpeed;
    }

    public void Shoot() //Shooting logic
    {
        Debug.Log(inventory.ActiveWeapon);
        inventory.ActiveWeapon.GetComponent<Weapon>().Shoot();
    }

    private void Aim() //Aiming logic
    {
        transform.rotation = Quaternion.LookRotation(new Vector3(_rightStick.x, 0, _rightStick.y));
    }
    
}
