using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerJump : MonoBehaviour
{
	[SerializeField] private float jumpForce;
	[SerializeField] private Transform RaycastStartTransform;
	public bool canJump { get; private set; }
    private Rigidbody2D rb2D;


    void Awake()
    {
        rb2D = GetComponent<Rigidbody2D>();
    }
    public void Jump()
    {
        if (canJump)
        {
            rb2D.AddForce(new Vector2(0, jumpForce), ForceMode2D.Impulse);
        }

    }

    void Update()
    {
    //Jump
        var hit = Physics2D.Raycast(RaycastStartTransform.position,Vector2.down, 0.001f);
    //Debug.DrawRay(RaycastStartTransform.position, new Vector2(0, -1) * 0.001f);
    
        canJump = hit.collider != null;
     //on peut sauter
     
    }
}