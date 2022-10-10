using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    [SerializeField] private Rigidbody rb;
    private float horizontalInput;
    private float verticalInput;

    [Header("Inputs")]
    [SerializeField] private float horSpeed;
    [SerializeField] private float verSpeed;
    [SerializeField] private bool jumpCheck = true;
    [SerializeField] private float jumpForce;

    [Header("Health")]
    public int maxHealth = 100;
    public int currentHealth;
    public Player_Health healthBar;


    private void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }


    void Update()
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
        if (currentHealth <= 0)
        {
            Debug.Log("Dead");
            currentHealth = maxHealth;
            // Destroy(gameObject);
        }
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector3(horizontalInput * horSpeed, rb.velocity.y, verticalInput * verSpeed);
    }
    private void Jump()
    {
        rb.velocity = new Vector3(rb.velocity.x, jumpForce, rb.velocity.z);
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;

        healthBar.SetHealth(currentHealth);
    }
    public void GiveHealth(int health)
    {
        currentHealth += health;

        healthBar.SetHealth(currentHealth);
    }
}