using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class turnText : MonoBehaviour
{
    Text turntext;
    GameObject GameManager;
    GameObject ScoreManager;
    public int Score = 0;

    int turnPlayer;

    // Start is called before the first frame update
    void Start()
    {
        GameManager = GameObject.Find("GameManager");
        ScoreManager = GameObject.Find("ScoreManager");
    }

    // Update is called once per frame
    void Update()
    {
        turnPlayer = GameManager.GetComponent<PlayerTurnManager>().turnPlayer;
        turntext = this.GetComponent<Text>();
        if (turnPlayer % 2 == 1)
        {
            turntext.text = "<color=red>Player1</color>のターンです";
        }
        if (turnPlayer % 2 == 0)
        {
            turntext.text = "<color=blue>Player2</color>のターンです";
        }
        
    }
}
