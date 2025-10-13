using UnityEngine;

namespace GameObjectsAndComponents
{
    public class ParameterizedMover : MonoBehaviour
    {

        private float distanceFromHome = 0.0f;
        private bool movingForward = true;


        public float Speed = 10.0f;
        public float Range = 10.0f;




        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            float distanceThisFrame = Speed * Time.deltaTime;
            if (movingForward)
            {
                if (distanceFromHome + distanceThisFrame < Range)
                {
                    distanceFromHome += distanceThisFrame;
                    transform.Translate(Vector3.forward * distanceThisFrame);
                }
                else
                {
                    movingForward = false;
                }
            }
            else
            {
                if (distanceFromHome - distanceThisFrame > 0.0f)
                {
                    distanceFromHome -= distanceThisFrame;
                    transform.Translate(Vector3.forward * distanceThisFrame * -1.0f);
                }
                else
                {
                    movingForward = true;
                }
            }
        }
    }
}
