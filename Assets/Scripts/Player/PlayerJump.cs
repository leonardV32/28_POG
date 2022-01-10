using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerJump : MonoBehaviour
{
	[SerializeField] private float jumpForce;

    
    private Rigidbody2D rb2D;
    private GroundCheck groundCheck;

    void Awake()
    {
        rb2D = GetComponent<Rigidbody2D>();
        groundCheck = GetComponent<GroundCheck>();
    }
    public void Jump()
    {
        if (groundCheck.canJump)
        {
            rb2D.AddForce(new Vector2(0, jumpForce), ForceMode2D.Impulse);
        }

    }

}