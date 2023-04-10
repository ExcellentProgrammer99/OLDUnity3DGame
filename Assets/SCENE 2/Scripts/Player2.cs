using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2 : MonoBehaviour {

	public AudioClip hurt;
	public AudioSource zrodloDzwieku;

	void OnTriggerEnter(Collider other) 
	{
		if (other.gameObject.CompareTag ( "VillainNumberTwo"))
		{
			Application.LoadLevel (Application.loadedLevel);


			if (zrodloDzwieku != null) {
				zrodloDzwieku.PlayOneShot (hurt);
			}
		}
	}
}
