using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class createCard : MonoBehaviour,ICreatable
{
    
    // Start is called before the first frame update
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CreateCard(GameObject card, int i, int j)
    {
        Instantiate(card, new Vector2(i * 2.5f, j * 3.0f), Quaternion.identity);

    }
    
}
