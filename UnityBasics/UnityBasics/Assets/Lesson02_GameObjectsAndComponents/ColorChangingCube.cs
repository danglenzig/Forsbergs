
using UnityEngine;

namespace GameObjectsAndComponents
{
    public class ColorChangingCube : MonoBehaviour
    {
        public float ColorSpeed = 0.5f;
        public float FloatMagnitude = 0.01f;

        private Renderer myRend;

        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            myRend = GetComponent<Renderer>();


        }

        // Update is called once per frame
        void Update()
        {
            float colorValue = Mathf.PingPong(Time.time, ColorSpeed);
            myRend.material.color = new Color( colorValue, 0.5f, (ColorSpeed - colorValue) );

            float yValue = Mathf.Sin(Time.time);
            transform.Translate(Vector3.up * (yValue * FloatMagnitude) * Time.deltaTime);

        }
    }

}

