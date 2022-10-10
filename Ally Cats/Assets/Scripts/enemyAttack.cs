using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyAttack : MonoBehaviour
{
    private float attackTime;
    [SerializeField] private GameObject player;
    [SerializeField] private int attRange;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(player.transform.position, transform.position) <= attRange)
        {
            StartCoroutine(Attack());
        }
    }
    public IEnumerator Attack()
    {
        yield return new WaitForSeconds(2f);
        if (Vector3.Distance(player.transform.position, transform.position) <= attRange)
        {
            Debug.Log("DAMAGE");
            var health = GameObject.FindObjectOfType(typeof(movement)) as movement;
            health.TakeDamage(10);

        }
        yield return new WaitForSeconds(0f);
    }
}
