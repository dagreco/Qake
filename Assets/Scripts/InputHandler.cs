using UnityEngine;
using static UnityEngine.InputSystem.InputAction;

public class InputHandler : MonoBehaviour
{
    //Components
    private PlayerController _playerController;

    //Controller modifiers
    [SerializeField] private float _rightStickDeadZone = 0.1f;

    //Input booleans (for performing actions while holding button)
    private bool _holdingShoulderR = false;

    private void Awake()
    {
        _playerController = GetComponent<PlayerController>();
    }

    public void LeftStickMoved(CallbackContext context)
    {
        _playerController._leftStick = context.ReadValue<Vector2>();
    }

    public void RightStickMoved(CallbackContext context)
    {
        if(context.ReadValue<Vector2>().magnitude > _rightStickDeadZone)
            _playerController._rightStick = context.ReadValue<Vector2>();
    }

    public void RightShoulderHeld(CallbackContext context)
    {
        if (context.performed)
            _holdingShoulderR = true;

        else if (context.canceled)
            _holdingShoulderR = false;   
    }

    private void Update()
    {
        _playerController.RightShoulderPressed = _holdingShoulderR;
    }
}
