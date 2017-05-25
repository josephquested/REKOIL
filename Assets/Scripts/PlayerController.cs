using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	Rigidbody2D rb;

	void Start ()
	{
		rb = GetComponent<Rigidbody2D>();
	}

	public void ReceiveInputDown (bool upDown, bool rightDown, bool downDown, bool leftDown)
	{
		if (upDown)
		{
			Fire(Vector2.up);
		}
		if (rightDown)
		{
			Fire(Vector2.right);
		}
		if (downDown)
		{
			Fire(Vector2.down);
		}
		if (leftDown)
		{
			Fire(Vector2.left);
		}
	}

	public float thrust;

	void Fire (Vector2 direction)
	{
		rb.AddForce(-direction * thrust, ForceMode2D.Impulse);
	}
}
