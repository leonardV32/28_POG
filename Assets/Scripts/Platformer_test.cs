using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Platformer_test : MonoBehaviour
{
    /*// Deplacement
    [SerializeField] private float speed; 
    [SerializeField] private float maxspeed;*/
    // Jump
    [SerializeField] private float jumpForce;
    [SerializeField] private Transform RaycastStartTransform;
    //End
    [SerializeField] private GameObject Endtrigger; //le gameobject qui symbolise la limite basse de l'écran.
    //Inventory
    [SerializeField] private FillInventory SlotsUI; //permet d'accéder à la fonction UpdateInventory en ajoutant ce script dans l'editor
    //Death
    [SerializeField] private Transform Spawn;

    //Jump
    private bool canJump = false;

    //Inventory
    public bool[] isFull;   // un boolean pour qualifier les cases du tableau remplie ou non
    public Sprite[] basket; //l'appel d'un tableau qui va accueillir les sprites 

    //Animation
    public GameObject Left_light;
    public GameObject Right_light;
    
    //Inputs
    //private Controls controls;
    // Animation
    private SpriteRenderer spriterenderer;
    private Animator animator;
    // Deplacement+Jump
    private Rigidbody2D rb2D;
    //Deplacement+anim
    private float direction;

    /*private void OnEnable()
    {
        controls = new Controls();
        controls.Enable();
        //controls.player2.Jump.performed += JumpOnperformed;
        controls.player2.Dep.performed += MoveOnperformed;
        controls.player2.Dep.canceled += MoveOncanceled;
    }*/


    /*private void JumpOnperformed(InputAction.CallbackContext obj)
    {
        if (canJump)
        {
            rb2D.AddForce(new Vector2(0, jumpForce), ForceMode2D.Impulse);
        }
        
    }*/

    /*private void MoveOnperformed(InputAction.CallbackContext obj)
    {
        direction = obj.ReadValue<float>();
        animator.SetBool("Walking", true);
        if (direction > 0)
        {
            spriterenderer.flipX = false;
            Left_light.SetActive(false);
            Right_light.SetActive(true);
        }
        else
        {
            spriterenderer.flipX = true;
            Left_light.SetActive(true);
            Right_light.SetActive(false);
        }
    }

    private void MoveOncanceled(InputAction.CallbackContext obj)
    {
        animator.SetBool("Walking", false);
        direction = 0;
    }*/
    // Start is called before the first frame update
    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();//deplacement
        spriterenderer = GetComponent<SpriteRenderer>();//animation
        animator = GetComponent<Animator>();//animation
        Left_light = GameObject.FindWithTag("Light_left");
        Right_light = GameObject.FindWithTag("Light_right");
        Left_light.SetActive(false);
        Right_light.SetActive(true);
    }

    // Update is called once per frame
    /*void Update()
    {   
        //Jump
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
    }*/

    //Deplacement
    /*private void FixedUpdate()
    {
        var horizontalSpeed = Mathf.Abs(rb2D.velocity.x);
        if (horizontalSpeed < maxspeed)
        {
            rb2D.AddForce(new Vector2(speed * direction, 0));
        }

    }*/

    //Collision 
    private void OnTriggerEnter2D(Collider2D collider2D)
    {
        //INventaire
        if (collider2D.tag == "Fruits") // vérifie si la collision est avec un gameobjet taggé Fruits
        {
            for (int i = 0; i < basket.Length; i++) //declenche une boucle for de la longueur du tableau dans lequel on va stocker les sprites des gameobjects récupérés.
            {
                if ( isFull[i] == false) //vérifie si le tableau est rempli pour cette valeur de i
                {
                    basket[i] = collider2D.gameObject.GetComponent<SpriteRenderer>().sprite; // rempli le tableau avec les gameobjects avec lesquelles il y a collision
                    isFull[i] = true; //indique que le tableau est rempli pour cette valeur de i
                    SlotsUI.UpdateInventory(basket); //lance la fonction UpdateInventory() dans le script FillInventory
                    collider2D.gameObject.SetActive(false); //d�sactive le game object collisionné
                    break; //arrête la fonction pour éviter le remplissage de chaque case du tableau.
                }
            }
        }   
        
        // End
        if (collider2D.tag == "End") //&& basket.Count == 3)
        {
            Endtrigger.SetActive(true); // affiche le panneau de fin du jeu
        }
        //Death
        if (collider2D.tag == "Death") // permet de collisionner avec un objet vide si le personnage tombe en dehors des plateformes.
        {
            rb2D.transform.position = Spawn.position;// replace le personnage au niveau du spawn du niveau 
            spriterenderer.flipX = false; // reset le personnage en position initiale.
        }
            
    }
    

}
