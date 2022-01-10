using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class FillInventory : MonoBehaviour
{
    [SerializeField] public GameObject[] slots; //créer un tableau de gameobject dans lequel on mets les éléments d'UI qui représente l'inventaire
    public Sprite sprite;
    public Sprite[] basket;
    public bool[] isFull;
    public GameObject inventorySlots;

    public UnityEvent spriteAdded;
    //private GameObject slot0;
    //private GameObject slot1;
    //private GameObject slot2;

    /*public void UpdateInventory(Sprite[] spriteList) // une fonction qui prend un tableau de sprite en paramètre, permet de récupérer les informations du tableau basket du script Platformer_test 
    {
        for (int i = 0; i < spriteList.Length; i++) //declenche une boucle for de la longueur du tableau basket 
        {
            if (spriteList[i] != null) // Si cette valeur de i dans le tableau basket est non-nulle, c-à-d que le tableau est rempli
            {
                slots[i].GetComponent<Image>().sprite = spriteList[i];// on remplace le sprite de slots[i] par le sprite contenu dans basket[i]
                slots[i].GetComponent<Image>().color = Color.white; // on mets la couleur de l'image de slots[i] en blanc, c-à-d tous les paramètres RGB et alpha à 255.
            }
            
        }
    }*/

    public void AddToInventory(Sprite sprite)
    {   
        for (int i = 0; i < basket.Length; i++)
        {
            
            if (isFull[i] == false)
            {
                Debug.Log("marche");
                basket[i] = sprite;
                isFull[i] = true;
                spriteAdded.Invoke();
                break;

            }
        }
    }

    public void RefreshUI()
    {
        for (int i = 0; i < 3; i++)
        {
            inventorySlots.transform.GetChild(i).gameObject.GetComponent<Image>().sprite = basket[i];
            inventorySlots.transform.GetChild(i).gameObject.GetComponent<Image>().color = Color.white;
        }
    }
        
        //slot0 = inventorySlots.transform.GetChild(0).gameObject;
        //slot1 = inventorySlots.transform.GetChild(1).gameObject;
        //slot2 = inventorySlots.transform.GetChild(2).gameObject;


       
}
    

