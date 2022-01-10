using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Fruit_Collision : MonoBehaviour
{
    [SerializeField] private FillInventory SlotsUI;
    public bool[] isFull;
    public Sprite[] basket;
    
   
     
    public void OnTriggerEnter(Collider2D collider2D)
    {   


        /*//INventaire
        if (collider2D.tag == "Player") // vérifie si la collision est avec un gameobjet taggé Fruits
        {
            for (int i = 0; i < basket.Length; i++) //declenche une boucle for de la longueur du tableau dans lequel on va stocker les sprites des gameobjects récupérés.
            {
                if (isFull[i] == false) //vérifie si le tableau est rempli pour cette valeur de i
                {
                    basket[i] = this.gameObject.GetComponent<SpriteRenderer>().sprite; // rempli le tableau avec les gameobjects avec lesquelles il y a collision
                    isFull[i] = true; //indique que le tableau est rempli pour cette valeur de i
                    SlotsUI.UpdateInventory(basket); //lance la fonction UpdateInventory() dans le script FillInventory
                    this.gameObject.SetActive(false); //d�sactive le game object collisionné
                    break; //arrête la fonction pour éviter le remplissage de chaque case du tableau.
                }
            }
        }*/

    }
   
}
