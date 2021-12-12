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

    private void Awake()
    {
        rigidBody = GetComponent<Rigidbody>();
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

    private void Move() //Movement logic
    {
        rigidBody.velocity = new Vector3(_leftStick.x, 0, _leftStick.y) * movementSpeed;
    }

    public void Shoot() //Shooting logic
    {
        transform.GetChild(0).gameObject.GetComponent<WeaponDefault>().Shoot();
    }

    private void Aim() //Aiming logic
    {
        transform.rotation = Quaternion.LookRotation(new Vector3(_rightStick.x, 0, _rightStick.y));
    }
    
}
