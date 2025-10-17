using UnityEngine;

namespace InputAndMovement
{
    public class RigidBodyPlayer : MonoBehaviour
    {

        [SerializeField] private float speed = 1000.0f;

        private SimplePlayerController controller;
        private Rigidbody rb;

        private void Awake()
        {
            rb = GetComponent<Rigidbody>();
            controller = GetComponent<SimplePlayerController>();
        }

        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            rb.linearDamping = 0.0f;
        }

        // Update is called once per frame
        void FixedUpdate()
        {
            Vector3 moveInput = controller.GetMoveInput();
            rb.AddForce(moveInput * speed);
        }
    }
}

