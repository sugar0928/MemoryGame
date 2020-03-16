using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class test2 : MonoBehaviour
{
    
    bool once = false;

    // Start is called before the first frame update
    void Start()
    {
        

    }

    // Update is called once per frame
    void Update()
    {
        if (!once)
        {
            this.GetComponent<Text>().text += "消せるかな?";
            once = true;
        }
    }
}
