using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerAnimationController : MonoBehaviour
{
	private Animator animator;
	private Rigidbody2D rb2D;
	private SpriteRenderer spriterenderer;

	public GameObject LeftLight;
	public GameObject RightLight;
        


    private void Awake()
    {
        rb2D = GetComponent<Rigidbody2D>();
        spriterenderer = GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();
    }

    private void Start()
    {
        LeftLight.SetActive(false);
        RightLight.SetActive(true);
    }

    public void OnMove(float direction)
    {   
        var isFacingRight = direction >= 0;
        animator.SetFloat("Speed", rb2D.velocity.x);
        spriterenderer.flipX = !isFacingRight;
        LeftLight.SetActive(!isFacingRight);
        RightLight.SetActive(isFacingRight);
             
    }
    
}
