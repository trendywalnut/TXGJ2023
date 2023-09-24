using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Diagnostics;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float MoveSpeed = 5.0f;

    [SerializeField] private float JumpForce = 7.0f;

    private Rigidbody2D rb;
    private bool CanJump;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        CanJump = true;
    }

    // Update is called once per frame
    void Update()
    {
        HorizontalMovement();
        Jump();
    }

    private void HorizontalMovement()
    {
        float xMovement = Input.GetAxisRaw("Horizontal");
        Vector2 movementVector = new Vector2(xMovement * MoveSpeed, rb.velocity.y);
        rb.velocity = movementVector;
    }

    private void Jump()
    {
        if(Input.GetKeyDown(KeyCode.Space) && CanJump)
        {
            Vector2 jumpVelocity = new Vector2(rb.velocity.x, JumpForce);
            rb.velocity = jumpVelocity;
            CanJump = false;
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.tag == "Floor")
        {
            CanJump = true;
        }
        if(other.gameObject.tag == "Trap")
        {
            MinigameManager.Instance.Timer.Stop();
            TimeSpan timeTaken = MinigameManager.Instance.Timer.Elapsed;
            UnityEngine.Debug.Log("Elapsed time: " + string.Format("{0:00}:{1:00}:{2:00}", timeTaken.Hours, timeTaken.Minutes, timeTaken.Seconds));
        }    
    }
}
