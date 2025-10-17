using UnityEngine;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace TarotMemory
{
    public class Dealer : MonoBehaviour
    {


        [SerializeField] private float rowHeight = 1.75f;
        [SerializeField] private float columnWidth = 1.25f;
        [SerializeField] private Game game;

        private List<GameObject> cards = new List<GameObject>();

        private void Start()
        {
            game.SetAcceptingClickInput(false);
            Transform[] allChildrenTranforms = GetComponentsInChildren<Transform>();
            cards = GetCardList(allChildrenTranforms);
            cards = SetupCards(cards);
            cards = ShuffleCards(cards,3);
            DealCards();
        }


        private List<GameObject> GetCardList(Transform[] _transforms)
        {
            List<GameObject> theList = new List<GameObject>();
            foreach (Transform t in _transforms)
            {
                if (t.gameObject.GetComponent<Card>())
                {
                    theList.Add(t.gameObject);
                }
            }
            return theList;
        }


        private List<GameObject> SetupCards(List<GameObject> _cards)
        {
            foreach (GameObject o in _cards)
            {
                Card card = o.GetComponent<Card>();
                card.SetGame(game);
            }
            return _cards;
        }

        private List<GameObject> ShuffleCards(List<GameObject> _cards, int _repeat)
        {
            // Fisher-Yates Shuffle Algorithm
            for (int count = 0; count < _repeat; count++)
            {
                for (int i = _cards.Count - 1; i > 0; i--)
                {

                    int j = UnityEngine.Random.Range(0, i + 1);
                    GameObject temp = _cards[i];
                    _cards[i] = _cards[j];
                    _cards[j] = temp;
                }
            }
            return _cards;
        }

        private async void DealCards()
        {
            Vector2 cardPos = new Vector2();
            for (int i = 0; i < 6; i++)
            {
                await Task.Delay(50);
                cardPos.y = 0.0f;
                cardPos.x = (i % 6) * columnWidth;
                Vector3 pos3 = new Vector3(cardPos.x, cardPos.y, 0.0f);
                cards[i].transform.position = pos3;
                
            }
            for (int i = 6; i < 12; i++)
            {
                await Task.Delay(50);
                cardPos.x = (i % 6) * columnWidth;
                cardPos.y = -rowHeight;
                Vector3 pos3 = new Vector3(cardPos.x, cardPos.y, 0.0f);
                cards[i].transform.position = pos3;
                
            }
            for (int i = 12; i < 18; i++)
            {
                await Task.Delay(50);
                cardPos.x = (i % 6) * columnWidth;
                cardPos.y = 2 * -rowHeight;
                Vector3 pos3 = new Vector3(cardPos.x, cardPos.y, 0.0f);
                cards[i].transform.position = pos3;
                
            }
            await Task.Delay(1500);
            FlipAllCards();
            game.SetAcceptingClickInput(true);
        }

        

        public async void FlipAllCards()
        {
            foreach (GameObject o in cards)
            {
                await Task.Delay(100);
                Card card = o.GetComponent<Card>();
                card.Flip();
            }
        }

    }
}

