using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreText : MonoBehaviour
{
    Text player1scoreText;
    Text player2scoreText;

    GameObject player1score;
    GameObject player2score;

    // Start is called before the first frame update
    void Start()
    {
        player1score = GameObject.Find("Player1score");
        player2score = GameObject.Find("Player2score");
        player1scoreText = player1score.GetComponent<Text>();
        player2scoreText = player2score.GetComponent<Text>();
        

    }

    // Update is called once per frame
    void Update()
    {
        player1scoreText.text = "" + this.GetComponent<ScoreManager>().player1score;
        player2scoreText.text = "" + this.GetComponent<ScoreManager>().player2score;
    }
}
