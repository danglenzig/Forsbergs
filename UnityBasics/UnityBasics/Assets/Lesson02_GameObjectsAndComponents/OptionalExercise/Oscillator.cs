using UnityEngine;

namespace GameObjectsAndComponents
{
    public class Oscillator : MonoBehaviour
    {

        public enum EnumWaveType { SINE, TRIANGLE, SQUARE }

        public EnumWaveType WaveType;

        public float Amplitude = 10.0f;
        public float Period = 1.0f;
        public float Ground = 0.0f;

        private float _currentValue;
        public float CurrentValue
        {
            get => _currentValue;
            private set
            {
                _currentValue = value;
            }
        }

        private float timeAccumulator = 0.0f;
        private bool squareWaveUp = false;


        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            Period = Mathf.Abs(Period);
            if (Period <= 0)
            {
                Period = 0.05f;
            }

            if (WaveType == EnumWaveType.SQUARE)
            {
                float startValue = (Amplitude * 0.5f) + Ground;
                CurrentValue = startValue;
            }

        }

        // Update is called once per frame
        void Update()
        {

            Period = Mathf.Abs(Period);
            if (Period <= 0)
            {
                Period = 0.05f;
            }

            switch (WaveType)
            {
                case EnumWaveType.SINE:
                    SineUpdate();
                    break;
                case EnumWaveType.TRIANGLE:
                    TriangleUpdate();
                    break;
                case EnumWaveType.SQUARE:
                    SquareUpdate();
                    break;
                //case default:
                //    break;
            }

        }


        void SineUpdate()
        {
            //float secondsElapsed = Time.time;
            //float whereInPeriod = Time.time % Period;
            //float fractionOfPeriod = (Time.time % Period) / Period;
            float angleRadians = ((Time.time % Period) / Period) * Mathf.PI * 2.0f;
            angleRadians -= Mathf.PI / 2.0f; // rotate half a circle, so we start at zero
            float rawSine = Mathf.Sin(angleRadians);
            float rawOffset = rawSine * Amplitude * 0.5f;
            float transposedToGround = rawOffset + Ground;
            CurrentValue = transposedToGround;
        }

        void TriangleUpdate()
        {
            float rawTriangle = Mathf.PingPong(Time.time, (Period / 2.0f)) / (Period / 2.0f);
            float distanceFromZero = Amplitude * rawTriangle;
            distanceFromZero -= Amplitude * 0.5f;

            distanceFromZero += Ground;

            CurrentValue = distanceFromZero;

        }

        void SquareUpdate()
        {
            timeAccumulator += Time.deltaTime;
            if (timeAccumulator < Period * 0.5f)
            {
                return;
            }
            timeAccumulator = 0.0f;

            float distanceFromGround = Amplitude * 0.5f;
            if (!squareWaveUp)
            {
                distanceFromGround *= -1;
            }
            squareWaveUp = !squareWaveUp;

            CurrentValue = distanceFromGround + Ground;


        }

        public float GetCurrentValue()
        {
            return CurrentValue;
        }


    }
}


