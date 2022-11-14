using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class movement : MonoBehaviour
{
    [SerializeField] Animator anim;
    [SerializeField] private Rigidbody rb;
    private float horizontalInput;
    private float verticalInput;

    [Header("Inputs")]
    [SerializeField] private float horSpeed;
    [SerializeField] private float verSpeed;
    [SerializeField] private bool jumpCheck = true;
    [SerializeField] private float jumpForce;
     CinemachineTrackedDolly trackdolly;
    public CinemachineVirtualCamera camma;
    [SerializeField] public float maxpos;
    [Header("Health")]
    public Player_Health healthBar;


    private void Start()
    {
        trackdolly = camma.GetCinemachineComponent<CinemachineTrackedDolly>();
    }

   
    private void Update()
    {
        if (trackdolly.m_PathPosition > maxpos)
        {
            maxpos = trackdolly.m_PathPosition;
        }
        if (trackdolly.m_PathPosition < maxpos)
        {
            trackdolly.m_PathPosition = maxpos;
        }

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
        anim.SetFloat("vert speed",rb.velocity.y);
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
        

        healthBar.TakeDamage(20);
    }
    public void GiveHealth(int health)
    {
        

        healthBar.TakeDamage(-20);
    }
    
}