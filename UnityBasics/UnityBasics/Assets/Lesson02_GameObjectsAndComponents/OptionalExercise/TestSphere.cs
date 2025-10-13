using UnityEngine;


namespace GameObjectsAndComponents
{
    public class TestSphere : MonoBehaviour
    {

        private Oscillator myOscillator = null;
        private Vector3 startPos;


        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            startPos = transform.position;
            myOscillator = GetComponent<Oscillator>();
        }

        // Update is called once per frame
        void Update()
        {
            if (myOscillator == null)
            {
                return;
            }

            float currentOscVal = myOscillator.GetCurrentValue();
            Vector3 newPos = new Vector3(0.0f, transform.position.y, startPos.z + currentOscVal);
            transform.position = newPos;

        }
    }
}

