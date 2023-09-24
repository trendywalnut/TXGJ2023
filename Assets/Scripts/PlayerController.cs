using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float MoveSpeed = 5.0f;

    [SerializeField] private float JumpForce = 7.0f;

    private Rigidbody2D rb;
    private bool CanJump;
    private bool FacingRight;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        CanJump = true;
        FacingRight = true;
    }

    // Update is called once per frame
    void Update()
    {
        HorizontalMovement();
        Jump();
        //FaceSprite();
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

    private void FaceSprite()
    {
        if (rb.velocity.x < 0 && FacingRight)
        {
            transform.localScale = new Vector3(-transform.localScale.x, transform.localScale.y, transform.localScale.z);
            FacingRight = false;
        }
        else if (rb.velocity.x > 0 && !FacingRight)
        {
            transform.localScale = new Vector3(-transform.localScale.x, transform.localScale.y, transform.localScale.z);
            FacingRight = true;
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
            Debug.Log("THE END");
        }    
    }
}
