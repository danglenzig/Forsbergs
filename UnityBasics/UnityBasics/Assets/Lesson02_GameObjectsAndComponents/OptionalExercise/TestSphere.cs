using UnityEngine;
using TMPro;


namespace GameObjectsAndComponents
{
    public class TestSphere : MonoBehaviour
    {

        [SerializeField] private TMP_Text waveLabel;
        [SerializeField] private TMP_Text periodLabel;
        [SerializeField] private GameObject highlightQuad;


        private float _period;
        public float Period
        {
            get => _period;
            private set
            {
                if (value < 0.5f)
                {
                    _period = 0.5f;
                }
                else
                {
                    _period = value;
                }
            }
        }


        private Oscillator.EnumWaveType _waveType;
        public Oscillator.EnumWaveType WaveType
        {
            get => _waveType;
            private set
            {
                _waveType = value;
            }
        }




        private Oscillator myOscillator = null;
        private Vector3 startPos;


        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {

            if (highlightQuad)
            {
                highlightQuad.SetActive(false);
            }

            startPos = transform.position;
            myOscillator = GetComponent<Oscillator>();

            Period = myOscillator.Period;
            WaveType = myOscillator.WaveType;


            periodLabel.text = stringifyPeriod(myOscillator.Period);
            switch (myOscillator.WaveType)
            {
                case Oscillator.EnumWaveType.SINE:
                    waveLabel.text = "Sine";
                    break;
                case Oscillator.EnumWaveType.TRIANGLE:
                    waveLabel.text = "Triangle";
                    break;
                case Oscillator.EnumWaveType.SQUARE:
                    waveLabel.text = "Square";
                    break;

            }
        }

        // Update is called once per frame
        void Update()
        {
            if (myOscillator == null)
            {
                return;
            }

            float currentOscVal = myOscillator.GetCurrentValue();
            Vector3 newPos = new Vector3(0.0f, startPos.y , startPos.z + currentOscVal);
            transform.position = newPos;

        }

        private string stringifyPeriod(float _period)
        {
            string _string = $"{_period.ToString()}Hz";
            return _string;
        }

        public void SetHighlightQuadVisible(bool _value)
        {
            highlightQuad.SetActive(_value);
        }

        public void IncrementPeriod()
        {
            Period += 0.25f;
            myOscillator.Period = Period;
            periodLabel.text = stringifyPeriod(Period);
        }
        public void DencrementPeriod()
        {
            Period -= 0.25f;
            myOscillator.Period = Period;
            periodLabel.text = stringifyPeriod(Period);
        }

        public void SetWaveType(Oscillator.EnumWaveType _waveType)
        {
            myOscillator.WaveType = _waveType;
            WaveType = myOscillator.WaveType;
            switch (myOscillator.WaveType)
            {
                case Oscillator.EnumWaveType.SINE:
                    waveLabel.text = "Sine";
                    break;
                case Oscillator.EnumWaveType.TRIANGLE:
                    waveLabel.text = "Triangle";
                    break;
                case Oscillator.EnumWaveType.SQUARE:
                    waveLabel.text = "Square";
                    break;

            }
        }

    }
}

