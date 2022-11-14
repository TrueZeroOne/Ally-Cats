using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Melee_Attack : MonoBehaviour
{
    private float timeBtwAttack;
    public float startTimeBtwAttack;

    public Animator anim;
    public string[] attackAnim;
    private int attackIndex;
    public Transform attackPos;
    public LayerMask whatIsEnemies;
    public float attackRange;
    public int damage;
    public float timer = 0.5f;

    void Update()
    {
        timer += Time.deltaTime;
        if(timer>=1)
        {
            attackIndex = 0;
        }
        if (timeBtwAttack <= 0)
        {
            //Then you can attack
            if (Input.GetButtonDown("Fire1"))
            {
                timer = 0;
                Debug.Log("attack index is "+attackIndex);
                anim.SetTrigger(attackAnim[attackIndex]);
                attackIndex++;
                attackIndex = attackIndex % 3;

                Collider[] enemiesToAttack = Physics.OverlapSphere(attackPos.position, attackRange, whatIsEnemies);
                for (int i = 0; i < enemiesToAttack.Length; i++)
                {
                    enemiesToAttack[i].GetComponent<EnemyHealth>().TakeDamage(damage); 
                }

                timeBtwAttack = startTimeBtwAttack;

           
             }
        }
        timeBtwAttack -= Time.deltaTime;
    }
    
}
