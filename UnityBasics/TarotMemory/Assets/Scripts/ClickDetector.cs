using UnityEngine;

namespace TarotMemory
{
    public class ClickDetector : MonoBehaviour
    {

        private bool cardSelectingEnabled = false;
        public bool CardSelectingEnabled
        {
            get => cardSelectingEnabled;
            set
            {
                if (value != cardSelectingEnabled)
                {
                    cardSelectingEnabled = value;
                }
            }
        }

        void Update()
        {
            if (Input.GetMouseButtonDown(0))
            {
                if (cardSelectingEnabled)
                {
                    Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                    RaycastHit hit;

                    if (Physics.Raycast(ray, out hit))
                    {
                        GameObject cardObject = hit.collider.gameObject.transform.parent.gameObject;
                        Card? card = cardObject.GetComponent<Card>();
                        if (card == null)
                        {
                            return;
                        }
                        if (card.faceUp)
                        {
                            return;
                        }
                        //Debug.Log(card.Selectable);
                        card.OnClicked();
                    }
                }
            }
        }
    }
}


