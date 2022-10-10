using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 20f;
    private int timeToDestroy = 5;
    public Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = transform.right * speed;

    }
    private void Update()
    {
        Object.Destroy(gameObject, 2.0f);
    }
}