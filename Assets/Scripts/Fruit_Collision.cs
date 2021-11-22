using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(CollisionManager))]
public class Fruit_Collision : CollisionManager
{
    [SerializeField] private FillInventory SlotsUI;
    public bool[] isFull;
    public Sprite[] basket;
    // Start is called before the first frame update
    void Start()
    {
        
    }
     
    public override void Colliding(Collider2D collidedWith)
    {
        //INventaire
        if (collidedWith.tag == "Fruits") // vérifie si la collision est avec un gameobjet taggé Fruits
        {
            for (int i = 0; i < basket.Length; i++) //declenche une boucle for de la longueur du tableau dans lequel on va stocker les sprites des gameobjects récupérés.
            {
                if (isFull[i] == false) //vérifie si le tableau est rempli pour cette valeur de i
                {
                    basket[i] = collidedWith.gameObject.GetComponent<SpriteRenderer>().sprite; // rempli le tableau avec les gameobjects avec lesquelles il y a collision
                    isFull[i] = true; //indique que le tableau est rempli pour cette valeur de i
                    SlotsUI.UpdateInventory(basket); //lance la fonction UpdateInventory() dans le script FillInventory
                    collidedWith.gameObject.SetActive(false); //d�sactive le game object collisionné
                    break; //arrête la fonction pour éviter le remplissage de chaque case du tableau.
                }
            }
        }

    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
