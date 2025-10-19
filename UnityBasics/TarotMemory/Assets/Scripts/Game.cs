using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace TarotMemory
{
    public class Game : MonoBehaviour
    {


        [SerializeField] private int matchingPairs = 9;
        [SerializeField] private GameObject discardMarker;
        [SerializeField] private ClickDetector clickDetector;
        [SerializeField] private UIController uIController;

        [SerializeField] private Button continueButton;

        private List<Card> selectedCards = new List<Card>();
        //private bool acceptingClickInput = false;
        private int collectedPairs = 0;
        private Vector3 stackVector = new Vector3(0.0f, 0.0f, 0.1f);
        private int guesses = 0;

        private bool okayToContinue = true;


        void Start()
        {
            continueButton.gameObject.SetActive(false);
        }

        public void StartGame()
        {
            clickDetector.CardSelectingEnabled = true;
        }

        public void OnContinueClicked()
        {
            okayToContinue = true;
        }

        public async void OnCardClicked(Card _card, bool _faceUp)
        {
            clickDetector.CardSelectingEnabled = false;
            if (selectedCards.Count < 2)
            {
                selectedCards.Add(_card);
                _card.Flip();


                if (selectedCards.Count < 2)
                {
                    uIController.ShowFlavorText(_card.Value, true);
                }
                else if (selectedCards[0].Value != selectedCards[1].Value)
                {
                    uIController.ShowFlavorText(_card.Value, false);
                }


                

                await Task.Delay(1000);


                if (selectedCards.Count == 2)
                {
                    guesses += 1;

                    string comboString = selectedCards[0].Value + selectedCards[1].Value;
                    uIController.ShowComboText(comboString);

                    if (selectedCards[0].Value == selectedCards[1].Value)
                    {
                        //Debug.Log("It's a match!");
                        StartCoroutine(HandleMatch());
                    }
                    else
                    {
                        //Debug.Log("Not a match :(");
                        StartCoroutine(HandleNotMatch());
                    }
                }
                else
                {
                    StartCoroutine(WaitThenEnableListen(0.5f));
                }
            }
        }

        private void OnGameComplete()
        {
            float accuracy = (float)collectedPairs / (float)guesses;
            Debug.Log($"Accuracy: {accuracy}");
        }

        private System.Collections.IEnumerator HandleMatch()
        {
            collectedPairs += 1;
            yield return new WaitForSeconds(1.0f);

            okayToContinue = false;
            continueButton.gameObject.SetActive(true);
            while (!okayToContinue)
            {
                yield return new WaitForSeconds(0.1f);
            }
            continueButton.gameObject.SetActive(false);



            uIController.ClearTexts();

            foreach (Card card in selectedCards)
            {
                Vector3 _stackVector = stackVector * collectedPairs;
                card.GoToMarker(discardMarker.transform.position - _stackVector);
            }
            yield return new WaitForSeconds(0.5f);
            selectedCards.Clear();

            if (collectedPairs >= matchingPairs)
            {
                OnGameComplete();
            }
            else
            {
                clickDetector.CardSelectingEnabled = true;
            }
        }

        private System.Collections.IEnumerator HandleNotMatch()
        {
            yield return new WaitForSeconds(1.0f);


            okayToContinue = false;
            continueButton.gameObject.SetActive(true);
            while (!okayToContinue)
            {
                yield return new WaitForSeconds(0.1f);
            }
            continueButton.gameObject.SetActive(false);


            uIController.ClearTexts();

            foreach (Card card in selectedCards)
            {
                card.Flip();
            }
            yield return new WaitForSeconds(0.5f);
            selectedCards.Clear();
            clickDetector.CardSelectingEnabled = true;
        }

        private System.Collections.IEnumerator WaitThenEnableListen(float waitTime)
        {
            yield return new WaitForSeconds(waitTime);
            clickDetector.CardSelectingEnabled = true;
        }
    }
}

