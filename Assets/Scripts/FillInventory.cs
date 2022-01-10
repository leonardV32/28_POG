using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FillInventory : MonoBehaviour
{
    [SerializeField] public GameObject[] slots; //cr�er un tableau de gameobject dans lequel on mets les �l�ments d'UI qui repr�sente l'inventaire
    public Sprite sprite;
    public void UpdateInventory(Sprite[] spriteList) // une fonction qui prend un tableau de sprite en param�tre, permet de r�cup�rer les informations du tableau basket du script Platformer_test 
    {
        for (int i = 0; i < spriteList.Length; i++) //declenche une boucle for de la longueur du tableau basket 
        {
            if (spriteList[i] != null) // Si cette valeur de i dans le tableau basket est non-nulle, c-�-d que le tableau est rempli
            {
                slots[i].GetComponent<Image>().sprite = spriteList[i];// on remplace le sprite de slots[i] par le sprite contenu dans basket[i]
                slots[i].GetComponent<Image>().color = Color.white; // on mets la couleur de l'image de slots[i] en blanc, c-�-d tous les param�tres RGB et alpha � 255.
            }
            
        }
    }

    public void AddToInventory()
    {
        Debug.Log("Added");
    }
    /*
     * if (isFull[i] == false) //v�rifie si le tableau est rempli pour cette valeur de i
                {
                    basket[i] = this.gameObject.GetComponent<SpriteRenderer>().sprite; // rempli le tableau avec les gameobjects avec lesquelles il y a collision
                    isFull[i] = true; //indique que le tableau est rempli pour cette valeur de i
                    filInventory.UpdateInventory(basket); //lance la fonction UpdateInventory() dans le script FillInventory
                    this.gameObject.SetActive(false); //d?sactive le game object collisionn�
                    break; //arr�te la fonction pour �viter le remplissage de chaque case du tableau.
                }*/
}
