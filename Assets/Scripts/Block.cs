using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : Hitpoints {

	// SYSTEM //

	void Start ()
	{
		spriteRenderer = GetComponent<SpriteRenderer>();
	}

	// DAMAGE //

	SpriteRenderer spriteRenderer;
	public Sprite[] sprites;

	public override void ReceiveDamage (int damage)
	{
		hitpoints -= damage;
		if (hitpoints <= 0)
		{
			Destroy(gameObject);
		}
		spriteRenderer.sprite = sprites[hitpoints];
	}
}
