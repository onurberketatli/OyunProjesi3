using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UcanBulluk : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            // Diðer objenin üzerindeki Enemy component'ini al
            Enemy enemyComponent = other.gameObject.GetComponent<Enemy>();

            // Eðer Enemy component'i varsa ve ChangeHealth fonksiyonu tanýmlýysa
            if (enemyComponent != null)
            {
                // Saðlýðý deðiþtir
                enemyComponent.ChangeHealth(50);
            }

            
        }
    }
}

