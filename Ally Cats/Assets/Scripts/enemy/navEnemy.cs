using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class navEnemy : MonoBehaviour
{
    //[SerializeField] Animator anim;
    [SerializeField] private GameObject playerObj;
    [SerializeField] public NavMeshAgent Agent;

    // Start is called before the first frame update
    void Start()
    {
        playerObj = GameObject.FindGameObjectWithTag("Player");
        Agent.destination = playerObj.transform.position;
        
    }

    // Update is called once per frame
    void Update()
    {
        Agent.destination = playerObj.transform.position;
        if (Agent.velocity.magnitude > 0)
        {
            //anim.SetTrigger("speed");
        }
    }
}
