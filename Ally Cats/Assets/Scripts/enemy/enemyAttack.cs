using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyAttack : MonoBehaviour
{
    public Animator anim;
    private float attackTime;
    [SerializeField] private GameObject player;
    [SerializeField] private int attRange;
    [SerializeField] private int attackspeed;
    private bool canAttack = true;
    private navEnemy nav;
    private DateTime attStart;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        nav = FindObjectOfType(typeof(navEnemy)) as navEnemy;
    }

    // Update is called once per frame
    void Update()
    {
        
        
            
        
        if (Vector3.Distance(player.transform.position, transform.position) <= attRange)
        {
            if(canAttack == true)
            {
                attStart = DateTime.Now;
                canAttack = false;
                Debug.Log("IS ATTACKING");
                
            }
            nav = gameObject.GetComponent<navEnemy>();
            nav.Agent.isStopped = true;
            TimeSpan ts = DateTime.Now - attStart;
            if (ts.TotalSeconds > attackspeed)
            {
                Debug.Log("DAMAGE");
                var health = FindObjectOfType(typeof(movement)) as movement;
                health.TakeDamage(10);
                nav.Agent.isStopped = false;
                canAttack = true;
                anim.SetTrigger("attack");
            }
        }
        else if (Vector3.Distance(player.transform.position, transform.position) > attRange && canAttack == false)
        {
            Debug.Log("ATTACK STOPPED");
            nav.Agent.isStopped = false;
            canAttack = true;
        }
    }
}
