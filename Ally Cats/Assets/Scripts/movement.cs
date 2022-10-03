using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    [SerializeField] private Rigidbody rb;
    private float horizontalInput;
    private float verticalInput;
    [SerializeField] private float horSpeed;
    [SerializeField] private float verSpeed;
    [SerializeField] private bool jumpCheck = true;
    [SerializeField] private float jumpForce;

    void Update()
    {
        horizontalInput = Input.GetAxisRaw("Horizontal");
        verticalInput = Input.GetAxisRaw("Vertical");
        if (Input.GetKeyDown(KeyCode.Space) && jumpCheck)
        {
            Jump();
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
}
