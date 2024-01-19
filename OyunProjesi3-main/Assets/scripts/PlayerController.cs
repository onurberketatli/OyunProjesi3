using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    int health = 100;
    public bool dead;
    [SerializeField] Animator anim;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void ChangeHealth(int count)
    {
        health -= count;
        if (health <= 0)
        {
            anim.SetBool("Die", true);
            this.enabled = false;

        }
    }
}
