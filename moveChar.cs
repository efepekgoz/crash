using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveChar : MonoBehaviour
{
    // Public variable to adjust the move speed of the player
    public float moveSpeed = 5f;
    // Reference to the Rigidbody2D component
    public Rigidbody2D rb;
    // Reference to the Animator component
    public Animator animator;

    void Start()
    {
        // Get the Rigidbody2D component and Animator component
        rb = GetComponent<Rigidbody2D>(); 
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        // Get the horizontal input axis
        float moveX = Input.GetAxis("Horizontal");

        // Set the velocity of the Rigidbody2D component
        rb.velocity = new Vector2(moveX * moveSpeed, rb.velocity.y);

        // Set the "isMoving" parameter in the Animator component
        animator.SetBool("isMoving", Mathf.Abs(moveX) > 0);

        // Mirror the character if moving left
        if (moveX < 0)
        {
            transform.localScale = new Vector3(-1, 1, 1);
        }
        // Unmirror the character if moving right
        else if (moveX > 0)
        {
            transform.localScale = new Vector3(1, 1, 1);
        }
    }
}
