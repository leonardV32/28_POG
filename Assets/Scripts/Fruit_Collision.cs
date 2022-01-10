using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Fruit_Collision : MonoBehaviour
{
    /*[SerializeField] private FillInventory fillInventory;
    public bool[] isFull;
    public Sprite[] basket;
    
   Pour ton FillInventory, je rajouterais une fonction AddToInventory 
   qui prendrait en paramètre un seul sprite qui s’ajouterait à la fin du tableau. 
   Comme ça tu n’aurais la variable basket dans FillInventory au lieu Fruit_Collision, ce qui fait plus de sens. 
   Cela te permettrait aussi de déporter la boucle for de Fruit_Collision à FillInventory.

    Dans SceneChange, je rajouterais un paramètre à la fonction LoadSceneAsync de type string 
    afin de charger la scène qu’on veut et pas juste GameScene avec ce script
    
    private void OnTriggerEnter2D(Collider2D collider2D)
    {
        var player = collider2D.GetComponent<FillInventory>();
        if (player is null) return;
        var sprite = GetComponent<SpriteRenderer>().sprite;
        player.AddToInventory();
        gameObject.SetActive(false);


        //INventaire
        if (collider2D.tag == "Player") // vérifie si la collision est avec un gameobjet taggé Fruits
        {
            for (int i = 0; i < basket.Length; i++) //declenche une boucle for de la longueur du tableau dans lequel on va stocker les sprites des gameobjects récupérés.
            {
                if (isFull[i] == false) //vérifie si le tableau est rempli pour cette valeur de i
                {
                    basket[i] = this.gameObject.GetComponent<SpriteRenderer>().sprite; // rempli le tableau avec les gameobjects avec lesquelles il y a collision
                    isFull[i] = true; //indique que le tableau est rempli pour cette valeur de i
                    fillInventory.UpdateInventory(basket); //lance la fonction UpdateInventory() dans le script FillInventory
                    this.gameObject.SetActive(false); //d�sactive le game object collisionné
                    break; //arrête la fonction pour éviter le remplissage de chaque case du tableau.
                }
            }
        }
        var myBool = true;
        Vector3 newPos;
        if (myBool)
            newPos = Vector3.zero;
        else
            newPos = Vector3.one;
        var position = myBool ? Vector3.zero : Vector3.one;

    }*/
   
}
