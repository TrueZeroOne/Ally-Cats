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
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        if (canAttack = true);
        {
            anim.SetTrigger("attack");
        }
        if (Vector3.Distance(player.transform.position, transform.position) <= attRange&&canAttack)
        {
            
        }
    }
}
