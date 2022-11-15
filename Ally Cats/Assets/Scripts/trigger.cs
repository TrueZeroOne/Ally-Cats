using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trigger : MonoBehaviour
{
    public Rigidbody rb;
    public BoxCollider[] camcollider;
    public GameObject cameraobj;

    [SerializeField] private GameObject spawner;
    private enemySpawner spawnerScript;
    private bool newWaves;
    // Start is called before the first frame update
    void Start()
    {
        camcollider = cameraobj.GetComponents<BoxCollider>();
        spawnerScript = spawner.GetComponent<enemySpawner>();
    }

    // Update is called once per frame
    void Update()
    {
        if (spawnerScript.waves == 0)
        {
            rb.isKinematic = false;
            if (gameObject.name == "trigger")
            {
                GetComponent<BoxCollider>().enabled = false;
            }
            for (int i = 0; i < camcollider.Length; i++)
            {
                camcollider[i].enabled = true;
            }

        }
    }


        

    private void OnTriggerEnter(Collider collision)
    {
        
        if (collision.gameObject.layer == 8)
        {
            rb.isKinematic = true;
            spawnerScript.waves = 3;
            for (int i = 0; i < camcollider.Length;i++)
            {
                camcollider[i].enabled = false;
               
            }
            spawner.GetComponent<enemySpawner>().enemySpawn();
        }
    }
}
