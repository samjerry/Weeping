using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyPathFinding : MonoBehaviour {

	private NavMeshAgent agent;
	private GameObject thePlayer;

	private Rigidbody myRB;
	private EnemyController _ec;

	void Start (){  
		
		agent = GetComponent<NavMeshAgent>();  
		myRB = GetComponent<Rigidbody>();
		thePlayer = GameObject.Find ("Player");
		_ec = GetComponent<EnemyController> ();
	}

	/*
	void Update(){
		// *if (!_ec.IsILOS) 
		{
			//agent.destination = thePlayer.transform.position;
		//	agent.SetDestination (thePlayer.transform.position);
		//	agent.
		}
		*

		agent.

	}
	*/

	void Update()
	{
		if (agent.enabled == _ec.IsILOS) 
			agent.enabled = !_ec.IsILOS;

		if (agent.enabled)
			agent.SetDestination (thePlayer.transform.position);
	}
		


	void OnTriggerEnter(Collider other){
		if (other.gameObject.CompareTag ("Player")) {
			myRB.velocity = -transform.forward * 2;
		}
	}
}

