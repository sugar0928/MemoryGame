using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlagManager : MonoBehaviour
{
    public bool CanNext = true;
    public bool FrontMatch = false;
    GameObject scoreManager;

    public int score;

    // Start is called before the first frame update
    void Start()
    {
        scoreManager = GameObject.Find("ScoreManager");
    }

    // Update is called once per frame
    void Update()
    {
        if (!CanNext && Input.GetKeyDown(KeyCode.Return))
        {
            CanNext = true;
            
            if (FrontMatch)
            {
                //scoreManager.GetComponent<ScoreManager>().AddScore(score);
                Destroy(this.GetComponent<ClickCardInformation>().FrontCard[0]);
                Destroy(this.GetComponent<ClickCardInformation>().FrontCard[1]);
                
                
                FrontMatch = false;
                
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
            else
            {
                Destroy(this.GetComponent<ClickCardInformation>().FrontCard[0]);
                Destroy(this.GetComponent<ClickCardInformation>().FrontCard[1]);
                this.GetComponent<PlayerTurnManager>().turnPlayer += 1;
                this.GetComponent<InstantiateEffectText>().SwapText();
                this.GetComponent<createBackCard>().ReCreateBackCard();
                
            }
        }
    }
}
