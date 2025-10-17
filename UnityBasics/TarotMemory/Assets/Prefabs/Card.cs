using UnityEngine;

namespace TarotMemory
{

    public class Card : MonoBehaviour
    {
        public bool debugMode = false;

        public int Value;
        [SerializeField] private float flipSpeed = 250.0f;
        

        private const float CLOSE_ENOUGH = 0.05f;

        //private Dealer dealer = null;
        private Game game = null;
        private bool selectable;
        public bool Selectable
        {
            get
            {
                return selectable;
            }
            set
            {
                if (value != selectable)
                {
                    selectable = value;
                }
            }
        }


        private bool beMoving = false;
        private Vector3 moveDest = new Vector3();

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
            Selectable = false;
            //Debug.Log(transform.rotation.y);
        }

        private void Update()
        {
            if (beFlipping)
            {
                Quaternion currentRot = transform.rotation;
                float targetY = 0.0f;
                Quaternion targetRot = new Quaternion();

                float targetZpos = 0.0f;

                if (faceUp)
                {
                    targetRot = Quaternion.Euler(0.0f, 0.0f, 0.0f);
                    targetY = 0.0f;
                    targetZpos = 0.0f;
                }
                else
                {
                    targetRot = Quaternion.Euler(0.0f, 180.0f, 0.0f);
                    targetY = 1.0f;
                    targetZpos = -0.25f;
                }

                if (Mathf.Abs(currentRot.y - targetY) <= CLOSE_ENOUGH)
                {
                    transform.rotation = targetRot;
                    faceUp = !faceUp;
                    beFlipping = false;

                    if (!faceUp)
                    {
                        selectable = true;
                    }
                    
                }
                else
                {
                    transform.rotation = Quaternion.RotateTowards(currentRot, targetRot, flipSpeed * Time.deltaTime);
                    //transform.position.z = Mathf.Lerp(transform.position.z, targetZpos, 10.0f * Time.deltaTime);
                    Vector3 targetPos = new Vector3(transform.position.x, transform.position.y, targetZpos);
                    Vector3 newPos = Vector3.Lerp(transform.position, targetPos, 10.0f * Time.deltaTime);
                    transform.position = newPos;
                }
                return;
            }
            if (beMoving)
            {

                float distance = Vector3.Distance(transform.position, moveDest);
                if (distance <= CLOSE_ENOUGH)
                {
                    beMoving = false;
                    float randoFloat = UnityEngine.Random.Range(-5.0f, 5.0f);
                    transform.rotation = Quaternion.Euler(0.0f, 180.0f, randoFloat);
                }
                else
                {
                    Vector3 newPos = Vector3.Lerp(transform.position, moveDest, 10.0f * Time.deltaTime);
                    transform.position = newPos;
                    
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
        public void SetGame(Game _game)
        {
            if (game == null)
            {
                game = _game;
            }
        }

        public void OnClicked()
        {
            if (!game)
            {
                return;
            }
            if (beFlipping)
            {
                return;
            }
            if (!Selectable)
            {
                Debug.Log("NOT SELECTABLE!!!!");
                return;
            }
            game.OnCardClicked(this, !faceUp);
        }

        public void GoToMarker(Vector3 destPos)
        {
            moveDest = destPos;
            beMoving = true;
        }

    }
}

