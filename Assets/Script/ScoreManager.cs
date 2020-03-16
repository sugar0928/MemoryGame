using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public delegate int Effect(int num);
public struct EffectNumber
{
    public Effect IEffect;
}

public class ScoreManager : MonoBehaviour,IAddable
{
    public int player1score = 0;
    public int player2score = 0;

    int turn;

    public int[] CardEffect = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0};
    public int[] EffectTurn = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0};

    GameObject GameManager;
    GameObject turnText;
    GameObject getScoreText;
    
    // Start is called before the first frame update
    void Start()
    {
        GameManager = GameObject.Find("GameManager");
        turnText = GameObject.Find("turnText");
        getScoreText = GameObject.Find("GetScore");
    }

    // Update is called once per frame
    void Update()
    {
        turn = GameManager.GetComponent<PlayerTurnManager>().turnPlayer;
    }

    public void AddScore(int score)
    {
        
        EffectNumber[] EffectNumbers = new EffectNumber[14];

        EffectNumbers[0].IEffect = Plus1;
        EffectNumbers[1].IEffect = Plus2;
        EffectNumbers[2].IEffect = Plus3;
        EffectNumbers[3].IEffect = Plus4;
        EffectNumbers[4].IEffect = Plus5;
        EffectNumbers[5].IEffect = Minus1;
        EffectNumbers[6].IEffect = Minus2;
        EffectNumbers[7].IEffect = Minus3;
        EffectNumbers[8].IEffect = Minus4;
        EffectNumbers[9].IEffect = Minus5;
        EffectNumbers[10].IEffect = DoubleUp;
        EffectNumbers[11].IEffect = TripleUp;
        EffectNumbers[12].IEffect = HalfDown;

        if (turn % 2 == 1)
        {
            for (int n = 0; n <=13; n++)
            {
                if(EffectTurn[n] == turn)
                {
                    score = EffectNumbers[CardEffect[n]].IEffect(score);
                }              
            }
            getScoreText.GetComponent<GetScoreText>().Score =  score;
            turnText.GetComponent<turnText>().Score = score;
            player1score += score;
            Debug.Log(player1score);
        }
        else
        {
            for (int n = 0; n <= 13; n++)
            {
                if (EffectTurn[n] == turn)
                {
                    score = EffectNumbers[CardEffect[n]].IEffect(score);
                }

            }
            //this.GetComponent<GetScoreText>().getScoreText(score);
            getScoreText.GetComponent<GetScoreText>().Score = score;
            turnText.GetComponent<turnText>().Score = score;
            //GameManager.GetComponent<FlagManager>().score = score;
            player2score += score;
            Debug.Log(player2score);
        }
    }

    int normal(int score)
    {
        return score;       
    }

    int Plus1(int score)
    {
        score += 1;
        
        return score;
    }

    int Plus2(int score)
    {
        score += 2;
       
        return score;
    }

    int Plus3(int score)
    {
        score += 3;

        return score;
    }

    int Plus4(int score)
    {
        score += 4;

        return score;
    }

    int Plus5(int score)
    {
        score += 5;
        return score;
    }

    int Minus1(int score)
    {
        score -= 1;
        return score;
    }

    int Minus2(int score)
    {
        score -= 2;
        return score;
    }

    int Minus3(int score)
    {
        score -= 3;
        return score;
    }

    int Minus4(int score)
    {
        score -= 4;
        return score;
    }

    int Minus5(int score)
    {
        score -= 5;
        return score;
    }

    int DoubleUp(int score)
    {
        score *= 2;
        return score;
    }

    int TripleUp(int score)
    {
        score *= 3;
        return score;
    }

    int HalfDown(int score)
    {
        score /= 2;
        return score;
    }
}
