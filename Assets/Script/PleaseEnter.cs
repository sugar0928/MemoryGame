using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PleaseEnter : MonoBehaviour
{

    float time = 0.0f;
    Text pleaseEnter;
    GameObject GameManager;
    float speed = 0.5f;

    // Start is called before the first frame update
    void Start()
    {
        GameManager = GameObject.Find("GameManager");
        pleaseEnter = this.GetComponent<Text>();

    }

    // Update is called once per frame
    void Update()
    {
        if (!GameManager.GetComponent<FlagManager>().CanNext)
        {
            pleaseEnter.color = GetAlphaColor(pleaseEnter.color);

        }
        else
        {
            pleaseEnter.color = new Color(1,1,1,0);
        }
    }

    Color GetAlphaColor(Color color)
    {

        time += Time.deltaTime * 5.0f * speed;

        color.a = Mathf.Cos(time) * 0.5f + 0.5f;

        return color;

    }
}
