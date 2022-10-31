using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public int enemyHealth;
    
    public void TakeDamage(int damage)
    {
        enemyHealth -= damage;
        Debug.Log("Damage Taken!!");
    }
    void Update()
    {
        if (enemyHealth <= 0)
        {
            Destroy(gameObject);
        }
    }
}
