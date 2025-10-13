using UnityEngine;


namespace GameObjectsAndComponents
{
    public class Spinner : MonoBehaviour
    {
        public float rotationSpeed = 90.0f;

        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            transform.Rotate(0f, (rotationSpeed * Time.deltaTime), 0f);
        }
    }

}
