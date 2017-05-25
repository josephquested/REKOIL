using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour {

	PlayerController controller;

	void Start ()
	{
		controller = GetComponent<PlayerController>();
	}

	void Update ()
	{
		UpdateInput();
	}

	void UpdateInput ()
	{
		controller.ReceiveInputDown(
			Input.GetButtonDown("Up"),
			Input.GetButtonDown("Right"),
			Input.GetButtonDown("Down"),
			Input.GetButtonDown("Left")
		);
	}
}
