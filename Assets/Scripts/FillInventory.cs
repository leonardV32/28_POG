using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FillInventory : MonoBehaviour
{
    [SerializeField] public GameObject[] slots; //créer un tableau de gameobject dans lequel on mets les éléments d'UI qui représente l'inventaire
    
    public void UpdateInventory(Sprite[] spritelist) // une fonction qui prend un tableau de sprite en paramètre, permet de récupérer les informations du tableau basket du script Platformer_test 
    {
        for (int i = 0; i < spritelist.Length; i++) //declenche une boucle for de la longueur du tableau basket 
        {
            if (spritelist[i] != null) // Si cette valeur de i dans le tableau basket est non-nulle, c-à-d que le tableau est rempli
            {
                slots[i].GetComponent<Image>().sprite = spritelist[i];// on remplace le sprite de slots[i] par le sprite contenu dans basket[i]
                slots[i].GetComponent<Image>().color = Color.white; // on mets la couleur de l'image de slots[i] en blanc, c-à-d tous les paramètres RGB et alpha à 255.
            }
            
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
