using UnityEngine;
using System.Collections;

public class ende : MonoBehaviour {
	


	void onTriggerEnter (Collider other) {
		if (other.gameObject.CompareTag ("Plane")) {
			Time.timeScale = 0;

		}

	}


}