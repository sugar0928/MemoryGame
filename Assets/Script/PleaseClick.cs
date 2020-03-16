using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PleaseClick : MonoBehaviour
{

    float time = 0.0f;
    Text pleaseClick;
    GameObject GameManager;
    float speed = 0.5f;

    // Start is called before the first frame update
    void Start()
    {
        pleaseClick = this.GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        pleaseClick.color = GetAlphaColor(pleaseClick.color);
    }

    Color GetAlphaColor(Color color)
    {

        time += Time.deltaTime * 5.0f * speed;

        color.a = Mathf.Cos(time) * 0.5f + 0.5f;

        return color;

    }
}
