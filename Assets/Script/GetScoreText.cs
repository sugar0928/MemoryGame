using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetScoreText : MonoBehaviour
{
    Text GetScoretext;
    GameObject GameManager;
    GameObject ScoreManager;
    public int Score;

    // Start is called before the first frame update
    void Start()
    {
        GetScoretext = this.GetComponent<Text>();
        GameManager = GameObject.Find("GameManager");
        ScoreManager = GameObject.Find("ScoreManager");
    }

    // Update is called once per frame
    void Update()
    {
        if (!GameManager.GetComponent<FlagManager>().CanNext && GameManager.GetComponent<FlagManager>().FrontMatch)
        {
            GetScoretext.text = "あたり!" + "\n" + Score + "ポイントゲット!\n";
        }
        if (!GameManager.GetComponent<FlagManager>().CanNext && !GameManager.GetComponent<FlagManager>().FrontMatch)
        {
            GetScoretext.text = "はずれ!" + "\n";
        }
        if(GameManager.GetComponent<FlagManager>().CanNext)
        {
            GetScoretext.text = "";
        }


        /*if (GameManager.GetComponent<FlagManager>().CanNext)
        {
            GetScoretext.GetComponent<Text>().color = new Color(1, 1, 1, 0);
        }
        else
        {
            GetScoretext.GetComponent<Text>().color = new Color(1, 1, 1, 1);
        }*/
    }
}
