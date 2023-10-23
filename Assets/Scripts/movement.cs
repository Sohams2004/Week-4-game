using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    AudioSource jumpSound;

    public float jumpHeight = 4.0f;
    public float jumpDuration = 0.5f;
    public float movementSpeed = 5.0f;


    [SerializeField]private bool isJumping = false;
    private float jumpStartTime;
    private float gravityScale;

    [SerializeField] public Rigidbody2D playerRb;

    private void Start()
    {
        gravityScale = playerRb.gravityScale;

        jumpSound = GetComponent<AudioSource>();
    }

    private void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");

        Vector2 movementVelocity = new Vector2(horizontalInput * movementSpeed, playerRb.velocity.y);
        playerRb.velocity = movementVelocity;

   
        if (Input.GetButton("Jump") && !isJumping)
        {

            isJumping = true;
            float initialJumpVelocity = (2 * jumpHeight) / jumpDuration;

            playerRb.velocity = new Vector2(playerRb.velocity.x, initialJumpVelocity);

            jumpSound.Play();
        }
    }

    private void OnCollisionStay2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Floor"))
        {
            isJumping = false;
        }

        if (other.gameObject.CompareTag("Player 2"))
        {
            isJumping = false;
        }
    }
}
