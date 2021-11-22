using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public abstract class CollisionManager : MonoBehaviour
{

    protected Rigidbody2D rb2D;
    protected SpriteRenderer spriteRenderer;
    protected Collider2D collidedWith;

    

    void Awake()
    {
        rb2D = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
               
    }


    public void OnTriggerEnter2D(Collider2D collider2D)
    {
        collidedWith = collider2D;
        Colliding(collidedWith);
    }

    public abstract void Colliding(Collider2D collidedWith);
}
