using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class BirdMovement : MonoBehaviour
{
    public float speed;
    public float jumpForce;

    public LayerMask groundMask;

    private Rigidbody2D _rb;
    private bool _isGrounded;

    private void Awake()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        transform.Translate(Input.GetAxis("Horizontal") * speed * Time.fixedDeltaTime, 0, 0);

        if (Input.GetKeyDown(KeyCode.W) && _isGrounded)
            _rb.AddForce(Vector2.up * jumpForce);
    }
}
