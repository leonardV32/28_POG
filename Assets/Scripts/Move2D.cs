using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Move2D : MonoBehaviour
{
    protected Rigidbody2D rb2D;
    private void Awake()
    {
        rb2D = GetComponent<Rigidbody2D>();
    }
    // Update is called once per frame
    public abstract void Move(float direction);
}
