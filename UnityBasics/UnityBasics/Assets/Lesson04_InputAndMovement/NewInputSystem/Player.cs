using UnityEngine;

namespace InputAndMovement
{
    public class Player : MonoBehaviour
    {
        [SerializeField] private float defaultMoveSpeed = 5.0f;
        [SerializeField] private float rotationSpeed = 15.0f;
        [SerializeField] private SimplePlayerController controller;

        private float moveSpeed;
        public float MoveSpeed
        {
            get
            {
                return moveSpeed;
            }
            private set
            {
                moveSpeed = value;
            }
        }

        private void Start()
        {
            MoveSpeed = defaultMoveSpeed;
        }


        private void Update()
        {

            

            Vector3 moveInput = controller.GetMoveInput();
            transform.Translate(moveInput * MoveSpeed * Time.deltaTime, Space.World);

            if (moveInput.magnitude > 0.0f)
            {
                Quaternion targetRotation = Quaternion.LookRotation(moveInput);
                transform.rotation = Quaternion.RotateTowards(transform.rotation, targetRotation, rotationSpeed * Time.deltaTime);
            }

        }

        public void SetMoveSpeed(float value)
        {
            MoveSpeed = value;
        }

    }
}

