using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class PlayerMove : Move2D
{
    public float speed;
    public float maxspeed;
    private float horizontalSpeed;

    public override void Move(float direction)
    {
        horizontalSpeed = Mathf.Abs(rb2D.velocity.x);
        if (horizontalSpeed < maxspeed)
        {
            rb2D.AddForce(new Vector2(speed * direction, 0));
            //Debug.Log("Move");
            Debug.Log(direction);
        }
    }
    
}
