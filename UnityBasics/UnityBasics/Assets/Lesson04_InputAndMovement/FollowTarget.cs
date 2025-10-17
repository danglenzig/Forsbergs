using UnityEngine;

namespace InputAndMovement
{
    public class FollowTarget : MonoBehaviour
    {


        public Transform target;
        public float speed = 2.0f;

        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            Vector3 direction = (target.position - transform.position).normalized;
            transform.position += direction * speed * Time.deltaTime;
        }
    }
}


