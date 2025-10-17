using UnityEngine;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace TarotMemory
{
    public class Game : MonoBehaviour
    {

        private Vector3 stackVector = new Vector3(0.0f, 0.0f, 0.1f);


        [SerializeField] private GameObject discardMarker;

        private List<Card> selectedCards = new List<Card>();
        private bool acceptingClickInput = false;


        private int collectedPairs = 0;

        void Start()
        {

        }

        public void OnCardClicked(Card _card, bool _faceUp)
        {
            if (!acceptingClickInput)
            {
                return;
            }
            acceptingClickInput = false;

            if (selectedCards.Count < 2)
            {
                selectedCards.Add(_card);
                _card.Selectable = false;
                _card.Flip();                
                if (selectedCards.Count == 2)
                {
                    if (selectedCards[0].Value == selectedCards[1].Value)
                    {
                        Debug.Log("It's a match!");
                        StartCoroutine(HandleMatch());
                    }
                    else
                    {
                        Debug.Log("Not a match :(");
                        StartCoroutine(HandleNotMatch());
                    }
                }
                else
                {
                    StartCoroutine(WaitThenEnableListen(0.5f));
                }
            }
        }

        public void SetAcceptingClickInput(bool _value)
        {
            acceptingClickInput = _value;
        }

        private System.Collections.IEnumerator HandleMatch()
        {
            collectedPairs += 1;
            yield return new WaitForSeconds(1.0f);
            foreach (Card card in selectedCards)
            {
                Vector3 _stackVector = stackVector * collectedPairs;
                //card.gameObject.SetActive(false);
                card.GoToMarker(discardMarker.transform.position - _stackVector);
            }
            selectedCards.Clear();
            acceptingClickInput = true;
        }

        private System.Collections.IEnumerator HandleNotMatch()
        {
            yield return new WaitForSeconds(1.0f);
            foreach (Card card in selectedCards)
            {
                card.Flip();
                card.Selectable = true;
            }
            selectedCards.Clear();
            acceptingClickInput = true;
        }

        private System.Collections.IEnumerator WaitThenEnableListen(float waitTime)
        {
            yield return new WaitForSeconds(waitTime);
            acceptingClickInput = true;
        }
    }
}

