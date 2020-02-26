using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class BirdMovement : MonoBehaviour
{
    public float speed;
    public float jumpForce;
    public float moveDirection = 1f;

    public LayerMask groundMask;
    public GroundCheck groundCheck;

    private Rigidbody2D _rb;

    private void Awake()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        Move(moveDirection);

        if (Input.GetKeyDown(KeyCode.W))
            Jump();  
    }

    public void Move(float direction)
    {
        transform.Translate(direction * speed * Time.fixedDeltaTime, 0, 0);
    }

    public void Jump()
    {
        // Force not always have the same power.
        if (groundCheck.GetIsGrounded())
            _rb.AddForce(Vector2.up * jumpForce);
    }
}
