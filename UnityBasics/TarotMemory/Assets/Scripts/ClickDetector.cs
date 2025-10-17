using UnityEngine;

namespace TarotMemory
{
    public class ClickDetector : MonoBehaviour
    {
        void Update()
        {
            if (Input.GetMouseButtonDown(0))
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
                    Debug.Log(card.Selectable);
                    card.OnClicked();
                }

            }
        }
    }
}


