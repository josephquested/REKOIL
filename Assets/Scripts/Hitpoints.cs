using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hitpoints : MonoBehaviour {

	// PROJECTILE //

	public void ReceiveProjectile (Projectile projectile)
	{
		ReceiveDamage(projectile.damage);
	}

	// DAMAGE //

	public int hitpoints;

	public virtual void ReceiveDamage (int damage)
	{
		hitpoints -= damage;
		if (hitpoints <= 0)
		{
			Destroy(gameObject);
		}
	}
}
