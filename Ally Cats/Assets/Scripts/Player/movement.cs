using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    [SerializeField] Animator anim;
    [SerializeField] private Rigidbody rb;
    private float horizontalInput;
    private float verticalInput;
    [SerializeField] private SpriteRenderer sprite;
    [SerializeField] private GameObject firePoint;

    [Header("Inputs")]
    [SerializeField] private float horSpeed;
    [SerializeField] private float verSpeed;
    [SerializeField] private bool jumpCheck = true;
    [SerializeField] private float jumpForce;
    [Header("Health")]
    public Player_Health healthBar;


    private void Start()
    {
        
    }
    private void Update()
    {

        horizontalInput = Input.GetAxisRaw("Horizontal");
        verticalInput = Input.GetAxisRaw("Vertical");
        if (Input.GetKeyDown(KeyCode.Space) && jumpCheck)
        {
            Jump();
        }
        
        if (Input.GetKeyDown(KeyCode.L))
        {
            TakeDamage(20);
        }
        if (Input.GetKeyDown(KeyCode.K))
        {
            GiveHealth(20);
        }

        

        anim.SetFloat("speed",rb.velocity.x);
        anim.SetFloat("speed-", rb.velocity.x);
        anim.SetFloat("vert speed",rb.velocity.y);
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector3(horizontalInput * horSpeed, rb.velocity.y, verticalInput * verSpeed);
        if (horizontalInput == -1)
        {
            sprite.flipX = true;
        }
        if (horizontalInput == 1)
        {
            sprite.flipX = false;
        }
        
    }
    private void Jump()
    {
        rb.velocity = new Vector3(rb.velocity.x, jumpForce, rb.velocity.z);
        if (horizontalInput == -1)
        {
            sprite.flipX = true;
        }
        if (horizontalInput == 1)
        {
            sprite.flipX = false;
        }
    }
    
    public void TakeDamage(int damage)
    {
        

        healthBar.TakeDamage(20);
    }
    public void GiveHealth(int health)
    {
        

        healthBar.TakeDamage(-20);
    }
    
}