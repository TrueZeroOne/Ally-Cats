using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb;
    private float horizontalInput;
    private float verticalInput;
    [SerializeField] private float horSpeed;
    [SerializeField] private float verSpeed;

    void Update()
    {
        horizontalInput = Input.GetAxisRaw("Horizontal");
        verticalInput = Input.GetAxisRaw("Vertical");
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(horizontalInput * horSpeed, verticalInput * verSpeed);
    }
}
