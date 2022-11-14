using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyAttack : MonoBehaviour
{
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
        if (Vector3.Distance(player.transform.position, transform.position) <= attRange&&canAttack)
        {
            StartCoroutine(Attack());
            canAttack = false;
        }
    }
    public IEnumerator Attack()
    {
        var nav = this.gameObject.GetComponent<navEnemy>();
        nav.Agent.isStopped = true;
        yield return new WaitForSeconds(2f);
        if (Vector3.Distance(player.transform.position, transform.position) <= attRange && player.transform.position.y < 0)
        {
            Debug.Log("DAMAGE");
            var health = FindObjectOfType(typeof(movement)) as movement;
            health.TakeDamage(10);   
        }
        nav.Agent.isStopped = false;
        canAttack = true;
        yield return new WaitForSeconds(0f);
    }
}
