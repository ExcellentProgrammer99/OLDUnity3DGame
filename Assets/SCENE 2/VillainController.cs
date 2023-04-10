using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class VillainController : MonoBehaviour {
	

	public NavMeshAgent agent;
	public float goalDistance = 40f;

	private void Start ()
	{
		Vector3 target = transform.position + Vector3.forward * goalDistance;
		agent.SetDestination (target);
	}
}