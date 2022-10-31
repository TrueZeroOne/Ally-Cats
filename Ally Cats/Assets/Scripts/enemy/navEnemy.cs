using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class navEnemy : MonoBehaviour
{
    [SerializeField] private GameObject playerObj;
    [SerializeField] public NavMeshAgent Agent;

    // Start is called before the first frame update
    void Start()
    {
        Agent.destination = playerObj.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        Agent.destination = playerObj.transform.position;
    }
}
