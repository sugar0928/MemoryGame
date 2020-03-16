using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class createBackCard : MonoBehaviour
{
    int i, j;

    GameObject card;
    // Start is called before the first frame update
    void Start()
    {
        card = (GameObject)Resources.Load("prefab/card");
        for (j = 1; j <= 4;)
        {
            for (i = 1; i <= 13; i++)
            {
                this.GetComponent<createCard>().CreateCard(card,i,j);
                
            }
            j++;
        }
        
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ReCreateBackCard()
    {
        int i1 = this.GetComponent<ClickCardInformation>().ClickCardPositionX[0];
        int i2 = this.GetComponent<ClickCardInformation>().ClickCardPositionX[1];
        int j1 = this.GetComponent<ClickCardInformation>().ClickCardPositionY[0];
        int j2 = this.GetComponent<ClickCardInformation>().ClickCardPositionY[1];

        this.GetComponent<createCard>().CreateCard(card, i1, j1);
        
        this.GetComponent<createCard>().CreateCard(card, i2, j2);
       
        this.GetComponent<ClickCardInformation>().ClickCardPositionX.Insert(0, 0);
        this.GetComponent<ClickCardInformation>().ClickCardPositionX.Insert(0, 0);
        this.GetComponent<ClickCardInformation>().ClickCardPositionY.Insert(0, 0);
        this.GetComponent<ClickCardInformation>().ClickCardPositionY.Insert(0, 0);

        this.GetComponent<ClickCardInformation>().ClickCardPositionX.RemoveAt(2);
        this.GetComponent<ClickCardInformation>().ClickCardPositionX.RemoveAt(2);
        this.GetComponent<ClickCardInformation>().ClickCardPositionX.RemoveAt(2);
        this.GetComponent<ClickCardInformation>().ClickCardPositionX.RemoveAt(2);

        this.GetComponent<ClickCardInformation>().ClickCardPositionY.RemoveAt(2);
        this.GetComponent<ClickCardInformation>().ClickCardPositionY.RemoveAt(2);
        this.GetComponent<ClickCardInformation>().ClickCardPositionY.RemoveAt(2);
        this.GetComponent<ClickCardInformation>().ClickCardPositionY.RemoveAt(2);



    }
}
