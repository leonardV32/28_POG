using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Platformer_test : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private float maxspeed;
    [SerializeField] private float jumpForce;
    [SerializeField] private Transform RaycastStartTransform;

    private bool canJump = false;

    private GameObject[] basket;

    private Controls controls;

    private SpriteRenderer spriterenderer;

    private Animator animator;

    private Rigidbody2D rb2D;

    private float direction;

    private void OnEnable()
    {
        controls = new Controls();
        controls.Enable();
        controls.Main.Jump.performed += JumpOnperformed;
        controls.Main.Move.performed += MoveOnperformed;
        controls.Main.Move.canceled += MoveOncanceled;
    }


    private void JumpOnperformed(InputAction.CallbackContext obj)
    {   
        if (canJump)
        {
         rb2D.AddForce(new Vector2(0, jumpForce), ForceMode2D.Impulse);
        }
        
    }

    private void MoveOnperformed(InputAction.CallbackContext obj)
    {
        direction = obj.ReadValue<float>();
        animator.SetBool("Walking", true);
        if (direction > 0)
        {
            spriterenderer.flipX = false;
        }
        else
        {
            spriterenderer.flipX = true;
        }
    }

    private void MoveOncanceled(InputAction.CallbackContext obj)
    {
        animator.SetBool("Walking", false);
        direction = 0;
    }
    // Start is called before the first frame update
    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
        spriterenderer = GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();
        //basket = new GameObject[];
    }

    // Update is called once per frame
    void Update()
    {
        var hit = Physics2D.Raycast(RaycastStartTransform.position, new Vector2(0, -1), 0.001f);
        //Debug.DrawRay(RaycastStartTransform.position, new Vector2(0, -1) * 0.001f);
        if (hit.collider != null)
        {
            canJump = true;
            //on peut sauter
        }
        else
        {
            canJump = false;
        }
    }

    private void FixedUpdate()
    {
        var horizontalSpeed = Mathf.Abs(rb2D.velocity.x);
        if (horizontalSpeed < maxspeed)
        {
            rb2D.AddForce(new Vector2(speed * direction, 0));
        }

    }
}
