using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerDeath : CollisionManager
{
    [SerializeField] private Transform Spawn;
    
   

    public override void Colliding(Collider2D collidedWith)
    {
        if (collidedWith.tag == "Death") // permet de collisionner avec un objet vide si le personnage tombe en dehors des plateformes.
        {
            rb2D.transform.position = Spawn.position;// replace le personnage au niveau du spawn du niveau 
            spriteRenderer.flipX = false; // reset le personnage en position initiale.
        }
    }

        
}
