using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ranged_Attack : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bulletPrefab;
    public float fireRate = 1f;
    public Animator anim;

    private float nextTimeToFire = 0f;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.F) && Time.time >= nextTimeToFire)
        {
            anim.SetTrigger("shoot");
            nextTimeToFire = Time.time + 1f / fireRate;
            
          
        }
    }


    void Shoot()
    {
        //Shooting Logic
        if(GameObject.FindGameObjectWithTag("Sprite").GetComponent<SpriteRenderer>().flipX == true)
        {
            Instantiate(bulletPrefab, new Vector3(firePoint.position.x-2,firePoint.position.y,firePoint.position.z), firePoint.rotation);
        }
        else if(GameObject.FindGameObjectWithTag("Sprite").GetComponent<SpriteRenderer>().flipX == false)
        {
            Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        }
        
    }
   
}
