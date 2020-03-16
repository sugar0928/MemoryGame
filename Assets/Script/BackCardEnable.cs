using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackCardEnable : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && this.GetComponent<FlagManager>().CanNext)
        {

            Vector3 aTapPoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Collider2D aCollider2d = Physics2D.OverlapPoint(aTapPoint);

            if (aCollider2d)
            {
                

                GameObject obj = aCollider2d.transform.gameObject;
                
                this.GetComponent<CreateFrontCard>().createFrontCard((int)(obj.transform.position.x / 2.5), (int)(obj.transform.position.y / 3));

                
                this.GetComponent<ClickCardInformation>().ClickCardPositionX.Insert(0, (int)(obj.transform.position.x / 2.5));
                this.GetComponent<ClickCardInformation>().ClickCardPositionY.Insert(0, (int)(obj.transform.position.y / 3));


                Destroy(obj);
                

            }
        }
    }
}
