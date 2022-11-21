using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemySpriteRotate : MonoBehaviour
{
    [SerializeField] private Quaternion rotate;
    public Transform playerXpos;
    public Transform enemyXpos;
    public SpriteRenderer sprite;

    // Start is called before the first frame update
    void Start()
    {
        playerXpos = GameObject.FindGameObjectWithTag("Player").transform;

    }

    // Update is called once per frame
    void Update()
    {
        if (playerXpos.position.x <enemyXpos.position.x)
        {
            sprite.flipX = true;
        }
        if (playerXpos.position.x > enemyXpos.position.x)
        {
            sprite.flipX = false;
        }
        transform.rotation = rotate;
    }
}
