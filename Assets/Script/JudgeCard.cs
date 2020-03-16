using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JudgeCard : MonoBehaviour
{
    public List<int> frontCardNumber;
    GameObject turntext;
    GameObject GameManager;
    GameObject ScoreManager;
    FlagManager flagManager;
    bool canNext;
    int turn;
    int i = 0;
    public int pair = 0;

    int[] effectPercent = { 10, 10, 8, 8, 3, 5, 5, 4, 4, 2, 1, 1, 1 };

    // Start is called before the first frame update
    void Start()
    {
       
        GameManager = GameObject.Find("GameManager");
        ScoreManager = GameObject.Find("ScoreManager");

        frontCardNumber.Add(0);
        frontCardNumber.Add(0);
        flagManager = this.GetComponent<FlagManager>();
    }

    // Update is called once per frame
    void Update()
    {
        canNext = flagManager.CanNext;
        turn = this.GetComponent<PlayerTurnManager>().turnPlayer;

        if (frontCardNumber[0] != 0 && frontCardNumber[1] != 0 && canNext)
        {
            flagManager.CanNext = false;
            
            if (frontCardNumber[0] == frontCardNumber[1])
            {
                if(i == 25)
                {
                    i = 0;
                }

                int effectNumber = this.GetComponent<RandomWithWeight>().randomWithWeight(effectPercent, effectPercent.Length);
                ScoreManager.GetComponent<ScoreManager>().EffectTurn[i] = turn + 2;
                ScoreManager.GetComponent<ScoreManager>().CardEffect[i] = effectNumber;
                this.GetComponent<InstantiateEffectText>().instantiateEffectText(effectNumber);              

                i++;

                ScoreManager.GetComponent<ScoreManager>().AddScore(frontCardNumber[0]);
               
                flagManager.FrontMatch = true;

                pair++;
                this.GetComponent<GameEnd>().gameEnd(pair);
                
                frontCardNumber[0] = 0;
                frontCardNumber[1] = 0;
                frontCardNumber.RemoveAt(2);
                frontCardNumber.RemoveAt(2);

            }
            else
            {
                flagManager.FrontMatch = false;
                frontCardNumber[0] = 0;
                frontCardNumber[1] = 0;
                frontCardNumber.RemoveAt(2);
                frontCardNumber.RemoveAt(2);
            }
        }
    }
}
