using UnityEngine;
using UnityEngine.InputSystem;

namespace InputAndMovement
{
    public class SimplePlayerController : MonoBehaviour
    {
        enum EnumOrientation { HORIZONTAL, VERTICAL }

        [SerializeField] private EnumOrientation Orientation = EnumOrientation.HORIZONTAL;
        [SerializeField] private bool allowGamePad = false;


        private Keyboard myKB;

        private void Awake()
        {
            myKB = Keyboard.current;
        }


        public Vector3 GetMoveInput()
        {
            Vector3 moveInput3 = GetKbMoveinput();
            if (allowGamePad && moveInput3.magnitude <= 0.0f)
            {
                // read the gamepad input
            }
            return moveInput3;
        }

        private Vector3 GetKbMoveinput()
        {
            float movePlusX = 0.0f;
            float moveMinusX = 0.0f;
            float movePlusY = 0.0f;
            float moveMinusY = 0.0f;

            if (myKB.wKey.isPressed)
            {
                movePlusY = 1.0f;
            }
            if (myKB.sKey.isPressed)
            {
                moveMinusY = -1.0f;
            }
            if (myKB.dKey.isPressed)
            {
                movePlusX = 1.0f;
            }
            if (myKB.aKey.isPressed)
            {
                moveMinusX = -1.0f;
            }

            float moveX = movePlusX + moveMinusX;
            float moveY = movePlusY + moveMinusY;
            
            if (Orientation == EnumOrientation.HORIZONTAL)
            {
                return new Vector3(moveX, 0.0f, moveY).normalized;
            }
            else
            {
                return new Vector3(moveX, moveY, 0.0f).normalized;
            }
        }
    }
}


