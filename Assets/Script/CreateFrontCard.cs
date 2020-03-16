using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateFrontCard : MonoBehaviour
{
    GameObject GameManager;
    List<CardDifinition.Card> cardList;
    GameObject A;
    GameObject Two;
    GameObject Three;
    GameObject Four;
    GameObject Five;
    GameObject Six;
    GameObject Seven;
    GameObject Eight;
    GameObject Nine;
    GameObject Ten;
    GameObject J;
    GameObject Q;
    GameObject K;



    // Start is called before the first frame update
    void Start()
    {
        A = (GameObject)Resources.Load("prefab/A");
        Two = (GameObject)Resources.Load("prefab/2");
        Three = (GameObject)Resources.Load("prefab/3");
        Four = (GameObject)Resources.Load("prefab/4");
        Five = (GameObject)Resources.Load("prefab/5");
        Six = (GameObject)Resources.Load("prefab/6");
        Seven = (GameObject)Resources.Load("prefab/7");
        Eight = (GameObject)Resources.Load("prefab/8");
        Nine = (GameObject)Resources.Load("prefab/9");
        Ten = (GameObject)Resources.Load("prefab/10");
        J = (GameObject)Resources.Load("prefab/J");
        Q = (GameObject)Resources.Load("prefab/Q");
        K = (GameObject)Resources.Load("prefab/K");

        GameManager = GameObject.Find("GameManager");
        cardList = GameManager.GetComponent<CardShuffle>().cardList;
        //cardList = GameManager.GetComponent<DebugCardShuffle>().cardList; //この行を有効にすると、カードの配置が簡単になります。 

    }

    // Update is called once per frame
    void Update()
    {


        
    }

    public void createFrontCard(int i, int j)
    {
        
        switch (cardList[(i - 1) + (j - 1) * 13].number)
        {
            
            case 1:
                GameObject a = Instantiate(A,new Vector2(i * 2.5f, j * 3.0f), Quaternion.identity) as GameObject;
                this.GetComponent<ClickCardInformation>().FrontCard.Insert(0,a);
                break;
            case 2:
                GameObject two = Instantiate(Two, new Vector2(i * 2.5f, j * 3.0f), Quaternion.identity) as GameObject;
                this.GetComponent<ClickCardInformation>().FrontCard.Insert(0,two);
                break;
            case 3:
                GameObject three = Instantiate(Three, new Vector2(i * 2.5f, j * 3.0f), Quaternion.identity) as GameObject;
                this.GetComponent<ClickCardInformation>().FrontCard.Insert(0,three);
                break;
            case 4:
                GameObject four = Instantiate(Four, new Vector2(i * 2.5f, j * 3.0f), Quaternion.identity) as GameObject;
                this.GetComponent<ClickCardInformation>().FrontCard.Insert(0,four);
                break;
            case 5:
                GameObject five = Instantiate(Five, new Vector2(i * 2.5f, j * 3.0f), Quaternion.identity) as GameObject;
                this.GetComponent<ClickCardInformation>().FrontCard.Insert(0,five);
                break;
            case 6:
                GameObject six = Instantiate(Six, new Vector2(i * 2.5f, j * 3.0f), Quaternion.identity) as GameObject;
                this.GetComponent<ClickCardInformation>().FrontCard.Insert(0,six);
                break;
            case 7:
                GameObject seven = Instantiate(Seven, new Vector2(i * 2.5f, j * 3.0f), Quaternion.identity) as GameObject;
                this.GetComponent<ClickCardInformation>().FrontCard.Insert(0,seven);
                break;
            case 8:
                GameObject eight = Instantiate(Eight, new Vector2(i * 2.5f, j * 3.0f), Quaternion.identity) as GameObject;
                this.GetComponent<ClickCardInformation>().FrontCard.Insert(0,eight);
                break;
            case 9:
                GameObject nine = Instantiate(Nine, new Vector2(i * 2.5f, j * 3.0f), Quaternion.identity) as GameObject;
                this.GetComponent<ClickCardInformation>().FrontCard.Insert(0,nine);
                break;
            case 10:
                GameObject ten = Instantiate(Ten, new Vector2(i * 2.5f, j * 3.0f), Quaternion.identity) as GameObject;
                this.GetComponent<ClickCardInformation>().FrontCard.Insert(0,ten);
                break;
            case 11:
                GameObject jack = Instantiate(J, new Vector2(i * 2.5f, j * 3.0f), Quaternion.identity) as GameObject;
                this.GetComponent<ClickCardInformation>().FrontCard.Insert(0,jack);
                break;
            case 12:
                GameObject queen = Instantiate(Q, new Vector2(i * 2.5f, j * 3.0f), Quaternion.identity) as GameObject;
                this.GetComponent<ClickCardInformation>().FrontCard.Insert(0, queen);
                break;
            case 13:
                GameObject king = Instantiate(K, new Vector2(i * 2.5f, j * 3.0f), Quaternion.identity) as GameObject;
                this.GetComponent<ClickCardInformation>().FrontCard.Insert(0,king);
                break;


        }
        this.GetComponent<JudgeCard>().frontCardNumber.Insert(0, cardList[(i - 1) + (j - 1) * 13].number);
        
    }
    
}
