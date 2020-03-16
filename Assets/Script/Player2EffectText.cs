using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player2EffectText : MonoBehaviour
{
    public Text player2EffectText;

    public int turn;
    public int EffectTurn;

    GameObject GameManager;
    GameObject ScoreManager;

    // Start is called before the first frame update
    void Start()
    {
        player2EffectText = this.GetComponent<Text>();
        player2EffectText.text = "かかっている効果" + "\n";

    }

    // Update is called once per frame
    void Update()
    {

    }
}
