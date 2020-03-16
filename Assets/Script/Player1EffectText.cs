using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player1EffectText : MonoBehaviour
{
    public Text player1EffectText;

    public int turn;
    public int EffectTurn;
    
    GameObject GameManager;
    GameObject ScoreManager;

    // Start is called before the first frame update
    void Start()
    {
        player1EffectText = this.GetComponent<Text>();
        player1EffectText.text = "かかっている効果" + "\n";

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void EffectText(int EffectNumber)
    {

    }
}
