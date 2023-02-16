using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5f;
    public float friction = 0.9f;
    private Rigidbody2D rb;
    private Animator animator;
    private bool isMoving = false;
    private bool isFacingLeft = false;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        float horizontalMovement = Input.GetAxisRaw("Horizontal");
        horizontalMovement *= friction;
        Vector2 movement = new Vector2(horizontalMovement, 0);

        rb.MovePosition(rb.position + movement * speed * Time.deltaTime);

        if (Input.GetKey(KeyCode.D))
        {
            isMoving = true;
            isFacingLeft = false;
        }
        else if (Input.GetKey(KeyCode.A))
        {
            isMoving = true;
            isFacingLeft = true;
        }
        else
        {
            isMoving = false;
        }

        animator.SetBool("isMoving", isMoving);
        animator.SetBool("isFacingLeft", isFacingLeft);
    }
}
