using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ranged_Attack : MonoBehaviour
{
    public Transform firePoint;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }


    void Shoot()
    {
        //Shooting Logic
    }
}
