using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour {

	// SYSTEM //

	public int damage;

	// TRIGGER //

	void OnTriggerEnter2D (Collider2D collider)
	{
		if (collider.GetComponent<Hitpoints>() != null)
		{
			collider.GetComponent<Hitpoints>().ReceiveProjectile(this);
			Destroy(gameObject);
		}
	}
}
