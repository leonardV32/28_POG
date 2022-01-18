using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerBehaviour : MonoBehaviour
{
    // private Component script
    // 1 pour le move
    private PlayerMove move;
    // 1 pour le jump
    private PlayerJump jump;
    // 1 pour les anims
    private PlayerAnimationController animations;
    // 1 pour les collisions
    //private CollisionManager collision;
    // 1 pour les
    protected float direction;

    void Awake()
    {
        move = GetComponent<PlayerMove>();
        animations = GetComponent<PlayerAnimationController>();
        jump = GetComponent<PlayerJump>();
        
    }


    public void OnMove(InputAction.CallbackContext obj)
    {
        direction = obj.ReadValue<float>();
        if (!obj.performed)
            return;
        //Debug.Log( "Behaviour");
        //Debug.Log( direction);
        animations.OnMove(direction);
    }

    public void OnJump(InputAction.CallbackContext obj)
    {
        if (!obj.performed)
            return;
        jump.Jump();
    }
    // Start is called before the first frame update
    

    // Update is called once per frame
    void FixedUpdate()
    {
        move.Move(direction);
    }
}
