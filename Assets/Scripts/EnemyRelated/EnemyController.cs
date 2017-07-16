using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour {

	private Rigidbody myRB;

	public float moveSpeed;

	public bool IsILOS; 
	public bool IsActive = false;

	private PlayerMovement thePlayer;
	private GameObject camera;

	// Use this for initialization
	void Start () 
	{
		camera = GameObject.Find("Main Camera");

		myRB = GetComponent<Rigidbody>();
		thePlayer = FindObjectOfType<PlayerMovement> ();
	}

	void Update()
	{

		Transform[] AngelILOS = camera.GetComponent<FOV> ().visibleTargets.ToArray (); //Zet de list met gameobjects naar een array.

		if (AngelILOS.Length > 0)
		{
			Debug.Log (AngelILOS[0].gameObject);
		}

		transform.position = new Vector3 (transform.position.x, 3.476f, transform.position.z);

		if(AngelILOS.Length > 0)
		{
			IsILOS = true;
		}
		else
		{
			IsILOS = false;
		}
	}
}
