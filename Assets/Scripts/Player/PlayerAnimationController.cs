using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerAnimationController : MonoBehaviour
{
	private Animator animator;
	private Rigidbody2D rb2D;
	private SpriteRenderer spriterenderer;

	public GameObject Left_light;
	public GameObject Right_light;
        


    private void Awake()
    {
        rb2D = GetComponent<Rigidbody2D>();
        spriterenderer = GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();
    }

    private void Start()
    {
        Left_light = GameObject.FindWithTag("Light_left");
        Right_light = GameObject.FindWithTag("Light_right");
        Left_light.SetActive(false);
        Right_light.SetActive(true);
    }

    public void OnMove(float direction)
    {   
        var isFacingRight = direction >= 0;
        animator.SetFloat("Speed", rb2D.velocity.x);
        spriterenderer.flipX = !isFacingRight;
        Left_light.SetActive(!isFacingRight);
        Right_light.SetActive(isFacingRight);
             
    }
    
}
