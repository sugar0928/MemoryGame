using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomWithWeight : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public int randomWithWeight(int[] WeightArray, int ArrayLength)
    {
        int Num = 0;
        int totalweight = 0;

        for (int i = 0; i < ArrayLength; i++)
        {
            totalweight += WeightArray[i];
        }
        float random = Random.value * totalweight;

        for (int i = 0; i < ArrayLength; i++)
        {
            if (random < WeightArray[i])
            {
                Num = i;
                break;
            }
            random -= WeightArray[i];
        }


        return Num;
    }
}
