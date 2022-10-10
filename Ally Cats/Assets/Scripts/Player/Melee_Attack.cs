using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Melee_Attack : MonoBehaviour
{
    private float timeBtwAttack;
    public float startTimeBtwAttack;

    public Transform attackPos;
    public LayerMask whatIsEnemies;
    public float attackRange;
    public int damage;


    void Update()
    {

        if (timeBtwAttack <= 0)
        {
            //Then you can attack
            if (Input.GetButtonDown("Fire1"))
            {
                Collider[] enemiesToAttack = Physics.OverlapSphere(attackPos.position, attackRange, whatIsEnemies);
                for (int i = 0; i < enemiesToAttack.Length; i++)
                {
                    enemiesToAttack[i].GetComponent<EnemyHealth>().TakeDamage(damage); 
                }

                timeBtwAttack = startTimeBtwAttack;

           
             }else{
            
                timeBtwAttack -= Time.deltaTime;
             }
        } 
       
    }
}
