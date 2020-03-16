using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickCardInformation : MonoBehaviour
{

    public List<int> ClickCardPositionX;
    public List<int> ClickCardPositionY;
    public List<GameObject> FrontCard;

    // Start is called before the first frame update
    void Start()
    {
        //ClickCardPosition[0] = new Vector2(0, 0);
        //ClickCardPosition[1] = new Vector2(0, 0);
        ClickCardPositionX[0] = 0;
        ClickCardPositionX[1] = 0;
        ClickCardPositionY[0] = 0;
        ClickCardPositionY[1] = 0;
        FrontCard[0] = null;
        FrontCard[1] = null;


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
