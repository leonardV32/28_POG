using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class End : CollisionManager
{
	[SerializeField] private GameObject Endtrigger;
	public override void Colliding(Collider2D collidedWith)
	{
		if (collidedWith.tag == "Player") //&& basket.Count == 3)
		{
			Endtrigger.SetActive(true); // affiche le panneau de fin du jeu
		}
	}
}
