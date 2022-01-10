using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerDeath : MonoBehaviour
{
    [SerializeField] private Transform Spawn;

    private Rigidbody2D rb2D;
    private SpriteRenderer spriteRenderer;

    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        rb2D = GetComponent<Rigidbody2D>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Death") // permet de collisionner avec un objet vide si le personnage tombe en dehors des plateformes.
        {
            rb2D.transform.position = Spawn.position;// replace le personnage au niveau du spawn du niveau 
            spriteRenderer.flipX = false; // reset le personnage en position initiale.
        }
    }

        
}
