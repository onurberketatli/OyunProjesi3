using UnityEngine;
using System.Collections;
using System.Threading;

public class Bullet : MonoBehaviour
{
    public Rigidbody projectile;
    public float speed = 20;
    public int turn = 0;

    // Use this for initialization
    void Start() { }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && turn == 0)
        {
            Rigidbody instanced = Instantiate(projectile, transform.position, transform.rotation) as Rigidbody;
            instanced.velocity = transform.TransformDirection(new Vector3(0, 0, speed));
            
        }

        if (Input.GetMouseButtonDown(0))
        {
            turn += 1;
        }


        if (turn == 2)
        {
            turn = 0;
            print("0 oldu");
        }

       
    }

   
}