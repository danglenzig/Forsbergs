using UnityEngine;

namespace GameObjectsAndComponents
{
    public class Oscillator : MonoBehaviour
    {

        public enum EnumWaveType { SINE, TRIANGLE}

        public EnumWaveType WaveType;

        public float Amplitude;
        public float Period;
        public float Ground;

        private float _currentValue;
        public float CurrentValue
        {
            get => _currentValue;
            private set
            {
                _currentValue = value;
            }
        }


        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }


        void SineUpdate()
        {

        }

        void TriangleUpdate()
        {

        }


    }
}


