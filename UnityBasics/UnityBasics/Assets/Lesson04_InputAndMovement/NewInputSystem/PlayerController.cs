using UnityEngine;
using UnityEngine.InputSystem;

namespace InputAndMovement
{
    public class PlayerController : MonoBehaviour
    {
        private PlayerInputActions inputActions;
        private Vector2 moveInput;
        public Vector2 MoveInput
        {
            get
            {
                return moveInput;
            }
        }


        public float moveSpeed;

      

        private void Awake()
        {
            inputActions = new PlayerInputActions();
        }

        private void OnEnable()
        {
            inputActions.Player.Enable();
            inputActions.Player.Move.performed += OnMove;
            inputActions.Player.Move.canceled += OnMove;
        }

        private void OnDisable()
        {
            inputActions.Player.Move.performed -= OnMove;
            inputActions.Player.Move.canceled -= OnMove;
            inputActions.Player.Disable();
        }

        

        private void OnMove(InputAction.CallbackContext context)
        {
            moveInput = context.ReadValue<Vector2>();
        }
    }
}