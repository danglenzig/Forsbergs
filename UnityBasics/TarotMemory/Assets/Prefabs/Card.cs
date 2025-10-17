using UnityEngine;

namespace TarotMemory
{

    public class Card : MonoBehaviour
    {
        public bool debugMode = false;

        public int Value;
        [SerializeField] private float flipSpeed = 250.0f;

        private const float CLOSE_ENOUGH = 0.05f;

        private Dealer dealer = null;
        
        
        

        private bool beFlipping = false;
        private bool _faceUp;
        private bool faceUp
        {
            get
            {
                return _faceUp;
            }
            set
            {
                if (value == _faceUp)
                {
                    return;
                }
                _faceUp = value;
                if (debugMode)
                {
                    Debug.Log(_faceUp);
                }
            }
        }


        private void Start()
        {
            faceUp = true;
            //Debug.Log(transform.rotation.y);
        }

        private void Update()
        {
            if (beFlipping)
            {
                Quaternion currentRot = transform.rotation;
                float targetY = 0.0f;
                Quaternion targetRot = new Quaternion();
                if (faceUp)
                {
                    targetRot = Quaternion.Euler(0.0f, 0.0f, 0.0f);
                    targetY = 0.0f;
                }
                else
                {
                    targetRot = Quaternion.Euler(0.0f, 180.0f, 0.0f);
                    targetY = 1.0F;
                }

                if (Mathf.Abs(currentRot.y - targetY) <= CLOSE_ENOUGH)
                {
                    transform.rotation = targetRot;
                    faceUp = !faceUp;
                    beFlipping = false;
                }
                else
                {
                    transform.rotation = Quaternion.RotateTowards(currentRot, targetRot, flipSpeed * Time.deltaTime);
                }
            }
        }

        public void Flip()
        {
            if (beFlipping)
            {
                return;
            }
            beFlipping = true;
        }
        public void SetDealer(Dealer _dealer)
        {
            if (dealer == null)
            {
                dealer = _dealer;
            }
        }

    }
}

