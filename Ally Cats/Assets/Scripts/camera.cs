using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{
    public Rigidbody rb;
    public BoxCollider trigger;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        trigger = GetComponent<BoxCollider>();
    }

    // Update is called once per frame
    void Update()
    { 
        
        

       rb.velocity *= 0f;

    }
    
}
