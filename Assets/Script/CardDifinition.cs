using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardDifinition : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public struct Card
    {
        public int mark;
        public int number;

        public Card(int mark, int number)
        {
            this.mark = mark;
            this.number = number;
        }
    }

    
}
