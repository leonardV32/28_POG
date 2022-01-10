using System.Collections;
using UnityEngine;

 public class GroundCheck : MonoBehaviour
 {
    [SerializeField] private Transform RaycastStartTransform;
    public bool canJump { get; private set; }
    private Rigidbody2D rb2D;

    void Awake()
    {
        canJump = true;
        rb2D = GetComponent<Rigidbody2D>();
    }

    // Use this for initialization
    void Start()
     {

     }

     // Update is called once per frame
     void Update()
     {
        var hit = Physics2D.Raycast(RaycastStartTransform.position, Vector2.down, 0.001f);
        //Debug.DrawRay(RaycastStartTransform.position, new Vector2(0, -1) * 0.001f);

        canJump = hit.collider != null;
    }
 }
