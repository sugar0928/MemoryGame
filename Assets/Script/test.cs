using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class test : MonoBehaviour
{

    GameObject[] BackCard;

    // Start is called before the first frame update
    void Start()
    {
        BackCard = GameObject.FindGameObjectsWithTag("back");
        

    }

    // Update is called once per frame
    void Update()
    {

        if (BackCard == null)
        {
            Debug.Log("end");
        }

    }
}
