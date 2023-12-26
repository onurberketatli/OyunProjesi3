using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class camLookat : MonoBehaviour
{
    public Transform player, cameraTrans;

    private void Start()
    {
        transform.Rotate(60f, 0f, 0f);
    }

    void Update()
    {
        cameraTrans.position = new Vector3(player.position.x,player.position.y + 16 , player.position.z -15);
        
    }
}