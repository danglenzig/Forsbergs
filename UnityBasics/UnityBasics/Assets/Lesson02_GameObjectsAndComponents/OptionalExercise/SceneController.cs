using UnityEngine;
using System.Collections.Generic;
//using UnityEngine.UI;

namespace GameObjectsAndComponents
{
    public class SceneController : MonoBehaviour
    {

        [SerializeField] private TestSphere topSphere;
        [SerializeField] private TestSphere middleSphere;
        [SerializeField] private TestSphere bottomSphere;

        private TestSphere selectedSphere = null;
        private List<TestSphere> spheres;

        // how do I make a list containing ^^these objects?


        private void Awake()
        {
            spheres = new List<TestSphere>
            {
                topSphere,middleSphere,bottomSphere
            };
        }


        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            if (!selectedSphere)
            {
                return;
            }

            if (Input.GetKeyDown(KeyCode.W))
            {
                switch (selectedSphere.WaveType)
                {
                    case Oscillator.EnumWaveType.SINE:
                        selectedSphere.SetWaveType(Oscillator.EnumWaveType.TRIANGLE);
                        break;
                    case Oscillator.EnumWaveType.TRIANGLE:
                        selectedSphere.SetWaveType(Oscillator.EnumWaveType.SQUARE);
                        break;
                    case Oscillator.EnumWaveType.SQUARE:
                        selectedSphere.SetWaveType(Oscillator.EnumWaveType.SINE);
                        break;
                }
                return;
            }

            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                selectedSphere.IncrementPeriod();
                return;
            }
            if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                selectedSphere.DencrementPeriod();
                return;
            }
        }

        public void OnButtonPressed(string _buttonString)
        {
            switch (_buttonString)
            {
                case "TOP":
                    topSphere.SetHighlightQuadVisible(true);
                    middleSphere.SetHighlightQuadVisible(false);
                    bottomSphere.SetHighlightQuadVisible(false);
                    selectedSphere = topSphere;
                    break;
                case "MIDDLE":
                    topSphere.SetHighlightQuadVisible(false);
                    middleSphere.SetHighlightQuadVisible(true);
                    bottomSphere.SetHighlightQuadVisible(false);
                    selectedSphere = middleSphere;
                    break;
                case "BOTTOM":
                    topSphere.SetHighlightQuadVisible(false);
                    middleSphere.SetHighlightQuadVisible(false);
                    bottomSphere.SetHighlightQuadVisible(true);
                    selectedSphere = bottomSphere;
                    break;

            }
        }


    }
}


