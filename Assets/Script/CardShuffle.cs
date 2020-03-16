using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using static CardDifinition;

public class CardShuffle : MonoBehaviour
{
    public List<CardDifinition.Card> cardList;

    int numbers = 13;

    int spade = 0;
    int club = 1;
    int heart = 2;
    int diamond = 3;

    

    // Start is called before the first frame update
    void Start()
    {
        InitializeCardList();
        ShuffleCard();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void InitializeCardList()
    {
        List<int> marks = new List<int>() { spade, club, heart, diamond };
        cardList = new List<CardDifinition.Card>();
        

        foreach(int mark in marks)
        {
            
            for (int i = 1; i <= numbers; i++)
            {
                CardDifinition.Card card = new CardDifinition.Card(mark, i);
                cardList.Add(card);
            }
        }
    }

    void ShuffleCard()
    {
        for(int i = 1; i < cardList.Count; i++)
        {
            CardDifinition.Card temp = cardList[i];
            int randomIndex = Random.Range(0, cardList.Count);
            cardList[i] = cardList[randomIndex];
            cardList[randomIndex] = temp;
        }
    }
}
