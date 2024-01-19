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
            // Di�er objenin �zerindeki Enemy component'ini al
            Enemy enemyComponent = other.gameObject.GetComponent<Enemy>();

            // E�er Enemy component'i varsa ve ChangeHealth fonksiyonu tan�ml�ysa
            if (enemyComponent != null)
            {
                // Sa�l��� de�i�tir
                enemyComponent.ChangeHealth(50);
            }

            
        }
    }
}

