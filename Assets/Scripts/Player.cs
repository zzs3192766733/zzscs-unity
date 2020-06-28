using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float hitPoint;
    public float damage;
    public float moveSpeed;
    public float climbSpeed;
    public float energy;
    public float jumpForce;
    protected Rigidbody2D rb;
    protected Collider2D col;
    protected void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        col = GetComponent<BoxCollider2D>();
    }
    protected void Update()
    {
        Move();
        if (Input.GetKeyDown(KeyCode.Space))
            rb.velocity = new Vector3(rb.velocity.x, jumpForce, 0);
    }
    protected void Move()
    {
        float hor = Input.GetAxis("Horizontal");
        rb.velocity = new Vector3(hor * moveSpeed, 0, 0);
    }
    protected void Climb()
    {
        float ver = Input.GetAxis("Vertical");
        rb.velocity = new Vector3(0, ver * climbSpeed, 0);
    }
    protected void Jump()
    {
        
    }
    protected void Attack()
    {

    }
}
