using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	// SYSTEM //

	Rigidbody2D rb;

	void Start ()
	{
		rb = GetComponent<Rigidbody2D>();
	}

	// INPUT //

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

	// FIRE //

	public GameObject projectilePrefab;
	public float thrust;
	public float projectileForce;

	void Fire (Vector2 direction)
	{
		GameObject projectileObj = Instantiate(projectilePrefab, transform.position, transform.rotation);
		projectileObj.GetComponent<Rigidbody2D>().AddForce(direction * projectileForce, ForceMode2D.Impulse);
		rb.AddForce(-direction * thrust, ForceMode2D.Impulse);
	}
}
