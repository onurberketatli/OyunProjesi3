using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class CanBari : MonoBehaviour
{

    public GameObject buff;
    public float can, animasyonYavasligi;
    private float maxCan, gercekScale;

    void Start()
    {
        maxCan = can;
    }

    
    void Update()
    {
        gercekScale = can / maxCan;

        if (transform.localScale.x > gercekScale)
        {
            transform.localScale= new Vector3(transform.localScale.x -(transform.localScale.x- gercekScale)/animasyonYavasligi,transform.localScale.y,transform.localScale.z);
        }

        if (transform.localScale.x < gercekScale)
        {
            transform.localScale = new Vector3(transform.localScale.x + (gercekScale - transform.localScale.x) / animasyonYavasligi, transform.localScale.y, transform.localScale.z);
        }

        if (Input.GetKeyDown("k") && can>0)
        {
            can -= 10;
        }

        if (Input.GetKeyDown("l") && can < maxCan)
        {
            can += 10;
        }
        if (can < 0)
        {
            can= 0; 
        }
        if (can > maxCan)
        {
            can = maxCan;
        }
    }

}
