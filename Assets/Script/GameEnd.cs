using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameEnd : MonoBehaviour
{
    GameObject ResultText;
    GameObject ScoreManager;
    GameObject[] FadeText;
    GameObject Retry;
    GameObject Return;
    int player1score;
    int player2score;
    int pair;

    // Start is called before the first frame update
    void Start()
    {
        ScoreManager = GameObject.Find("ScoreManager");
        ResultText = GameObject.Find("ResultText");
        FadeText = GameObject.FindGameObjectsWithTag("FadeText");
        Retry = GameObject.Find("Retry");
        Return = GameObject.Find("Return");
        Retry.SetActive(false);
        Return.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        pair = this.GetComponent<JudgeCard>().pair;

        if (pair == 26 && this.GetComponent<FlagManager>().CanNext)
        {
            foreach (GameObject fadetext in FadeText)
            {
                fadetext.SetActive(false);
            }
            player1score = ScoreManager.GetComponent<ScoreManager>().player1score;
            player2score = ScoreManager.GetComponent<ScoreManager>().player2score;
            if (player1score > player2score)
            {
                ResultText.GetComponent<Text>().text = "<color=red>Player1</color>の勝ち!!";
            }
            if (player1score < player2score)
            {
                ResultText.GetComponent<Text>().text = "<color=blue>Player2</color>の勝ち!!";
            }
            if (player1score == player2score)
            {
                ResultText.GetComponent<Text>().text = "引き分け!!";
            }
            Retry.SetActive(true);
            Return.SetActive(true);
        }

    }

    public void gameEnd(int pair)
    {
        
    }
}
