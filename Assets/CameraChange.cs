using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraChange : MonoBehaviour {
	public GameObject ThirdPersonView;
	public GameObject FirstPersonView;
	public int CamMode;


	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown ("Camera")) 
		{
			if(CamMode ==1){
				CamMode = 0;}
			else {CamMode +=1;}
			StartCoroutine (CamChange ());
		}
		
	}
	IEnumerator CamChange ()
	{
		yield return new WaitForSeconds (0.01f);
		if (CamMode == 0) {
			ThirdPersonView.SetActive (true);
			FirstPersonView.SetActive (false);
		}
		if (CamMode == 1) {
			
			ThirdPersonView.SetActive (false);
			FirstPersonView.SetActive (true);
		}
	}
}
