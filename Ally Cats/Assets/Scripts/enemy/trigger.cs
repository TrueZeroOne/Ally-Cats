using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trigger : MonoBehaviour
{
    public Rigidbody rb;
    public BoxCollider[] camcollider;
    public GameObject cameraobj;
    private BoxCollider owncollider;
    static int currentdirection;
    [SerializeField] private GameObject spawner;
    public enemySpawner spawnerScript;
    public int amountOfWaves;
    public int enemyPerWave;

    
    // Start is called before the first frame update
    void Start()
    {
        camcollider = cameraobj.GetComponents<BoxCollider>();
        spawnerScript = spawner.GetComponent<enemySpawner>();
        owncollider = GetComponent<BoxCollider>();
        spawnerScript.enemiesPerWave = enemyPerWave;
    }

    // Update is called once per frame
    void Update()
    {
        if (spawnerScript.waves == 0)
        {
            rb.isKinematic = false;

            camcollider[currentdirection].enabled = true;
        }
        
        
    }

    void DisableAllCollliders()
    {
        for (int i = 0; i < camcollider.Length; i++)
        {
            camcollider[i].enabled = false;
        }
    }
        

    private void OnTriggerEnter(Collider collision)
    {
        
        if (collision.gameObject.layer == 8)
        {
            rb.isKinematic = true;
            spawnerScript.waves = amountOfWaves;
            spawnerScript.enemiesPerWave = enemyPerWave;
            owncollider.enabled = false;
            for (int i = 0; i < camcollider.Length;i++)
            {
                camcollider[i].enabled = false;
               
            }
            spawnerScript.enemySpawn();

            DisableAllCollliders();
            if (transform.tag == "Right")
            {   
                rb.constraints = RigidbodyConstraints.FreezePositionZ | RigidbodyConstraints.FreezeRotation;
                currentdirection = 0;
            }
            if (transform.tag == "Up")
            {
                
                rb.constraints = RigidbodyConstraints.FreezePositionX | RigidbodyConstraints.FreezeRotation;
                 

                currentdirection = 1;
            }
            if (transform.tag == "Down")
            {
                rb.constraints = RigidbodyConstraints.FreezePositionX | RigidbodyConstraints.FreezeRotation;

                currentdirection = 2;
            }
        }
    }
}
