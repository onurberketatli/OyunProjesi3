using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            // Di�er objenin �zerindeki Enemy component'ini al
            Enemy enemyComponent = collision.gameObject.GetComponent<Enemy>();

            // E�er Enemy component'i varsa ve ChangeHealth fonksiyonu tan�ml�ysa
            if (enemyComponent != null)
            {
                // Sa�l��� de�i�tir
                enemyComponent.ChangeHealth(10);
            }

            // Bu nesneyi yok et
            Destroy(gameObject);
        }
        if (collision.gameObject.CompareTag("wall"))
        {
            

            // Bu nesneyi yok et
            Destroy(gameObject);
        }
    }
}
