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

    private void Equp()
    {
        //TODO Implement picking up items 
    }

    private void Move() //Movement logic
    {
        rigidBody.velocity = new Vector3(_leftStick.x, 0, _leftStick.y) * movementSpeed;
    }

    private void Aim() //Aiming logic
    {
        transform.rotation = Quaternion.LookRotation(new Vector3(_rightStick.x, 0, _rightStick.y));
    }
    public void Shoot() //Shooting logic
    {
        inventory.ActiveWeapon.GetComponent<Weapon>().Shoot();
    }

    public void UseEquipment() //Euipment use logic
    {
        /* TODO Implement using equipment
         * inventory.ActiveEquipment.GetComponent<Item>().Use(); */
         
    }
}
