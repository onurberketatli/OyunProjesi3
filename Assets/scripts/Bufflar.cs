using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bufflar : MonoBehaviour
{
    [SerializeField] Image buff1;
    [SerializeField] Image buff2;
    [SerializeField] Image buff3;
    void Start()
    {
         
        buff1.color = Color.grey;
        buff2.color = Color.grey;
        buff3.color = Color.grey;
        Invoke("A",3f);
          
    }

   
    void Update()
    {
        
    }
    public void A()
    {
        buff1.color = Color.green;
        buff2.color = Color.green;
        buff3.color = Color.green;
    }
}


