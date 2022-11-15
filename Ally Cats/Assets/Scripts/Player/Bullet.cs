using JetBrains.Annotations;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 20f;
    private int timeToDestroy = 2;
    private DateTime createTime;
    public Rigidbody rb;
    int damage = 10;
    public GameObject player;
    
   
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Sprite");
        if (player.GetComponent<SpriteRenderer>().flipX == false)
        {
            rb.velocity = transform.right * speed;
        }
        else if(player.GetComponent<SpriteRenderer>().flipX == true)
        {
            rb.velocity = transform.right * speed*-1;
        }
        GetComponent<EnemyHealth>();
        createTime = DateTime.Now;
        
    }
    private void Update()
    {
        TimeSpan ts = DateTime.Now - createTime;
        if (ts.TotalSeconds > timeToDestroy )
        {
            Destroy(gameObject);
        }
        
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Enemy")
        {
            other.GetComponent<EnemyHealth>().TakeDamage(damage);
            Destroy(gameObject);
        }
    }



}