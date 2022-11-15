using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trigger : MonoBehaviour
{
    public Rigidbody rb;
    public BoxCollider[] camcollider;
    public GameObject cameraobj;

    // Start is called before the first frame update
    void Start()
    {
        camcollider = cameraobj.GetComponents<BoxCollider>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }


        

    private void OnTriggerEnter(Collider collision)
    {
        
        if (collision.gameObject.layer == 8)
        {
            rb.isKinematic = true;
            for (int i = 0; i < camcollider.Length;i++)
            {
                camcollider[i].enabled = false;
            }
        }
    }
}
