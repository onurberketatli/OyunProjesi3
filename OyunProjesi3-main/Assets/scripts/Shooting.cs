using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public int damage;
    public float timeBetweenShooting, spread, range, reloadTime, timeBetweenShoot;
    public int magazineSize, bulletPerTap;
    public bool allowButtonHold;
    public int bulletsLeft, bulletsShot;

    public bool shooting, readyToShoot, reloading;

    public Transform bulletSpawnPoint;
    public Transform attackPoint;
    public RaycastHit rayHit;
    public LayerMask whatIsEnemy;
    void Start()
    {
        readyToShoot = true;
    }

    
    void Update()
    {
        MyInput();
    }

    private void MyInput()
    {
        if (allowButtonHold) shooting = Input.GetMouseButton(0);
        else shooting = Input.GetMouseButtonDown (0);

        if(readyToShoot && shooting)
        {
            Shoot();
        }
    }

    private void Shoot()
    {
        readyToShoot = false;

        float x = Random.Range(-spread, spread);
        float y = Random.Range(-spread, spread);

        Vector3 direction = bulletSpawnPoint.transform.forward + new Vector3 (x, y, 0);

        if (Physics.Raycast(bulletSpawnPoint.transform.position,direction, out rayHit, range, whatIsEnemy))
        {
            Debug.Log(rayHit.collider.name);
            
            if (rayHit.collider.CompareTag("Enenmy"))
                rayHit.collider.GetComponent<ShootingAi>().TakeDamage(damage);

            
        }
        
        
        Invoke("ResetShoot", timeBetweenShooting);

        
    }

    private void ResetShoot()
    {
        readyToShoot=true;
    }
}
