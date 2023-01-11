using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
public class MovementScript : MonoBehaviour
{
    public float speed = 5.0f;
    public float jumpForce = 10.0f;
    public LayerMask groundLayer;
    float threshold = 0.1f;
    bool isMoving = false;
    private Rigidbody2D rb;
    private BoxCollider2D boxCollider;
    private bool isGrounded = false;
    PhotonView view;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        boxCollider = GetComponent<BoxCollider2D>();
        view = GetComponent<PhotonView>();
    }

    void Update()
    {
        if(view.IsMine  == true)
        {

                // The player is moving
                // Check if the player is grounded
                isGrounded = Physics2D.IsTouchingLayers(boxCollider, groundLayer);

                // Get input for horizontal movement
                float horizontalInput = Input.GetAxis("Horizontal");

                // Move the player
                rb.velocity = new Vector2(horizontalInput * speed, rb.velocity.y);

                // Check if the player wants to jump
                if (Input.GetButtonDown("Jump") && isGrounded)
                {
                    rb.velocity = new Vector2(rb.velocity.x, jumpForce);
                }

        }

    }
}
