using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Moves The Player Following the movement of the camera
/// </summary>

public class PlayerMovement : MonoBehaviour 
{
	private float moveSpeed = 3;

	private Vector3 moveInput;
	private Vector3 moveVelocity;

	void Update()
	{
		
		float y = transform.position.y; 
		if (Input.GetKey(KeyCode.W))
		{
			transform.position = transform.position + Camera.main.transform.forward * moveSpeed * Time.deltaTime;
		}

		if (Input.GetKey(KeyCode.A))
		{
			transform.position = transform.position + -Camera.main.transform.right * moveSpeed * Time.deltaTime;
		}

		if (Input.GetKey(KeyCode.S))
		{
			transform.position = transform.position + -Camera.main.transform.forward * moveSpeed * Time.deltaTime;
		}
	
		if (Input.GetKey(KeyCode.D))
		{
			transform.position = transform.position + Camera.main.transform.right * moveSpeed * Time.deltaTime;
		}
		transform.position = new Vector3 (transform.position.x, 3.447f, transform.position.z);
	}
}
