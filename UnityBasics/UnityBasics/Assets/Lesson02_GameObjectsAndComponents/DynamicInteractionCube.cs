using UnityEngine;

namespace GameObjectsAndComponents
{
    public class DynamicInteractionCube : MonoBehaviour
    {

        private int myInt;
        public int MyInt
        {
            get => myInt;
            set
            {
                if (value < 0)
                {
                    myInt = 0;
                }
                else
                {
                    myInt = value;
                }
            }
        }


        private Spinner mySpinner;
        private Mover myMover;

        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            mySpinner = GetComponent<Spinner>();
            myMover = GetComponent<Mover>();
        }

        // Update is called once per frame
        void Update()
        {
            if (Input.GetKeyDown(KeyCode.M))
            {
                if (myMover != null)
                {
                    myMover.enabled = !myMover.enabled;
                }
            }
            if (Input.GetKeyDown(KeyCode.S))
            {
                if (mySpinner != null)
                {
                    mySpinner.enabled = !mySpinner.enabled;
                }
            }
        }
    }
}


