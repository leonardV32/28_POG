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
    private CollisionManager collision;
    // 1 pour les
    protected float direction;


    public void OnMove(InputAction.CallbackContext obj)
    {
        if (!obj.performed)
            return;
        direction = obj.ReadValue<float>();
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
    void Awake()
    {
        move = GetComponent<PlayerMove>();
        animations = GetComponent<PlayerAnimationController>();
        jump = GetComponent<PlayerJump>();
        collision = GetComponent<CollisionManager>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        move.Move(direction);
    }
}
