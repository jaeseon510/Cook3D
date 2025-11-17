using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class GameInput : MonoBehaviour
{

    public event EventHandler OnInteractAction;
    private PlayerInputActions playerInputActions;
    private void Awake()
    {
        playerInputActions = new PlayerInputActions();
        playerInputActions.Player.Enable();
        playerInputActions.Player.Interact.performed += Interact_performed;
    }

    private void Interact_performed(UnityEngine.InputSystem.InputAction.CallbackContext obj)
    {
        // if (OnInteractAction != null)
        // {
        //     OnInteractAction(this, EventArgs.Empty);
        // }
        OnInteractAction?.Invoke(this,EventArgs.Empty);
    }
    
    public Vector2 GetMovementVectorNomarlized()
    {
        Vector2 inputVector = playerInputActions.Player.Move.ReadValue<Vector2>();

        inputVector = inputVector.normalized;

        //Debug.Log(inputVector);
        return inputVector;
    }
}
