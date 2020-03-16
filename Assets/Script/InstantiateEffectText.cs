using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InstantiateEffectText : MonoBehaviour
{
    
    int turn;

    GameObject GameManager;

    Text player1NextEffetText;
    Text player2NextEffetText;

    Text player1ThisEffetText;
    Text player2ThisEffetText;

    
    // Start is called before the first frame update
    void Start()
    {
        GameManager = GameObject.Find("GameManager");
        
        player1NextEffetText = GameObject.Find("NP1Effect").GetComponent<Text>();
        player2NextEffetText = GameObject.Find("NP2Effect").GetComponent<Text>();
        player1ThisEffetText = GameObject.Find("TP1Effect").GetComponent<Text>();
        player2ThisEffetText = GameObject.Find("TP2Effect").GetComponent<Text>();


    }

    // Update is called once per frame
    void Update()
    {
        turn = this.GetComponent<PlayerTurnManager>().turnPlayer;

    }

    public void instantiateEffectText(int effectNumber)
    {
        
        if (turn % 2 == 1)
        {
            writeText(effectNumber, player1NextEffetText);

        }
        else
        {
            writeText(effectNumber, player2NextEffetText);
        }
    }

    void writeText(int n, Text effecttext)
    {
        if(n == 0)
        {
            effecttext.text += "スコア +1\n";
        }
        if (n == 1)
        {
            effecttext.text += "スコア +2\n";
        }
        if (n == 2)
        {
            effecttext.text += "スコア +3\n";
        }
        if (n == 3)
        {
            effecttext.text += "スコア +4\n";
        }
        if (n == 4)
        {
            effecttext.text += "スコア +5\n";
        }
        if (n == 5)
        {
            effecttext.text += "スコア -1\n";
        }
        if (n == 6)
        {
            effecttext.text += "スコア -2\n";
        }
        if (n == 7)
        {
            effecttext.text += "スコア -3\n";
        }
        if (n == 8)
        {
            effecttext.text += "スコア -4\n";
        }
        if (n == 9)
        {
            effecttext.text += "スコア -5\n";
        }
        if (n == 10)
        {
            effecttext.text += "スコア ×2\n";
        }
        if (n == 11)
        {
            effecttext.text += "スコア ×3\n";
        }
        if (n == 12)
        {
            effecttext.text += "スコア 半分\n";
        }
        
    }

    public void SwapText()
    {
        if (turn % 2 == 1)
        {
            player1ThisEffetText.text = "";
            player2ThisEffetText.text = player2NextEffetText.text;
            player2NextEffetText.text = "";

        }
        else
        {
            player2ThisEffetText.text = "";
            player1ThisEffetText.text = player1NextEffetText.text;
            player1NextEffetText.text = "";
        }
    }
}
