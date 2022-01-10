using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewFruitCollision : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")// à gérer dans les layers
        {
            var player = collision.GetComponent<FillInventory>();
            if (player is null) return;
            var sprite = GetComponent<SpriteRenderer>().sprite;
            player.AddToInventory(sprite);
            gameObject.SetActive(false);
        }

        
    }
}
