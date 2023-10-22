using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{ 
    public float jumpHeight = 4.0f; 
    public float jumpDuration = 0.5f; 
    public float movementSpeed = 5.0f;

    private bool isJumping = false;
    private float jumpStartTime;
    private float gravityScale;

    [SerializeField] public Rigidbody2D playerRb;

    private void Start()
    {
        gravityScale = playerRb.gravityScale;
    }

    private void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        
        Vector2 movementVelocity = new Vector2(horizontalInput * movementSpeed, playerRb.velocity.y);
        playerRb.velocity = movementVelocity;

        if (Input.GetButtonDown("Jump") && !isJumping)
        {
            
            float initialJumpVelocity = (2 * jumpHeight) / jumpDuration;

            playerRb.velocity = new Vector2(playerRb.velocity.x, initialJumpVelocity);
            isJumping = true;
            jumpStartTime = Time.time;
        }

        if (isJumping)
        {
            float timeSinceJumpStart = Time.time - jumpStartTime;
            if (timeSinceJumpStart >= jumpDuration)
            {
                isJumping = false;
                playerRb.gravityScale = gravityScale;
            }
            else
            {
                float gravityEffect = (jumpHeight * 2) / Mathf.Pow(jumpDuration, 2);
                playerRb.velocity = new Vector2(playerRb.velocity.x, playerRb.velocity.y - gravityEffect * Time.deltaTime);
            }
        }
    }
}
