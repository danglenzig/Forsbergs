using UnityEngine;
using System.Collections.Generic;

namespace TarotMemory
{
    public class CardSpawner : MonoBehaviour
    {

        //[SerializeField] private GameObject cardPrefab;
        [SerializeField] private List<GameObject> cardPrefabs;
        [SerializeField] private float columnWidth = 1.25f;
        [SerializeField] private float rowHeight = 1.75f;


        //private Vector2[] row0;
        //private Vector2[] row1;
        //private Vector2[] row2;

        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            SetupPositions();
        }

        // Update is called once per frame
        void Update()
        {

        }

        private void SetupPositions()
        {
            for (int i = 0; i < 6; i++)
            {
                float xPos = i * columnWidth;
                float yPos = 0.0f;
                Vector3 spawnPos = new Vector3(xPos, yPos, 0.0f);
                //GameObject newCard = Instantiate(cardPrefab);
                //newCard.transform.position = spawnPos;
            }

            for (int i = 0; i < 6; i++)
            {
                float xPos = i * columnWidth;
                float yPos = -rowHeight;
                Vector3 spawnPos = new Vector3(xPos, yPos, 0.0f);
                //GameObject newCard = Instantiate(cardPrefab);
                //newCard.transform.position = spawnPos;
            }

            for (int i = 0; i < 6; i++)
            {
                float xPos = i * columnWidth;
                float yPos = -2 * rowHeight;
                Vector3 spawnPos = new Vector3(xPos, yPos, 0.0f);
                //GameObject newCard = Instantiate(cardPrefab);
                //newCard.transform.position = spawnPos;
            }
        }

       

    }
}


