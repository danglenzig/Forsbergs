using UnityEngine;

namespace InputAndMovement
{
    public class LocalVsWorldMovement : MonoBehaviour
    {

        public float moveSpeed = 3.0f;
        public float rotSpeed = 180.0f;
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

            float move = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
            float turn = Input.GetAxis("Horizontal") * rotSpeed * Time.deltaTime;

            transform.Translate(Vector3.up * move);
            transform.Rotate(Vector3.forward * -turn);
        }
    }
}


