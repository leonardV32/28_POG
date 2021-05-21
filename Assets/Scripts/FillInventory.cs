using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FillInventory : MonoBehaviour
{
    [SerializeField] public GameObject[] slots;
    public void UpdateInventory(Sprite[] spritelist)
    {
        for (int i = 0; i < spritelist.Length; i++)
        {
            if (spritelist[i] != null)
            {
                slots[i].GetComponent<Image>().sprite = spritelist[i];
                slots[i].GetComponent<Image>().color = Color.white;
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
