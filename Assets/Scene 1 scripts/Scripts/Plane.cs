using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Plane : MonoBehaviour {

	public AudioClip win;
	public AudioSource zrodloDzwieku;
	public Canvas finish;
	public Button PlayAgain;
	public Button Next;

	void Start () {
		finish = finish.GetComponent<Canvas> ();
		Next = Next.GetComponent<Button> ();
		PlayAgain = PlayAgain.GetComponent<Button> ();
		finish.enabled = false;
		Next.enabled = false;
		PlayAgain.enabled = false;
		Cursor.visible = finish.enabled;
		
	}

	void Update () {
		Cursor.visible = finish.enabled;
		if (finish.enabled) {
			Cursor.visible = true;
			Cursor.lockState = CursorLockMode.Confined;
			Time.timeScale = 0;
			Next.enabled = true;
			PlayAgain.enabled = true;
		} 
	}
	void OnTriggerEnter(Collider other) 
	{
		if (other.gameObject.CompareTag ("Plane")) {
			


			finish.enabled = true;


			if (zrodloDzwieku != null) {
				zrodloDzwieku.PlayOneShot (win);
			} 
		} 
	}
	public void PrzyciskNowyPoziom()
	{
		finish.enabled = false;
		Time.timeScale = 1;
		Application.LoadLevel(3);
		Cursor.visible = false;
		Cursor.lockState = CursorLockMode.Locked;
	}
	public void PrzyciskOdNowa()
	{
		finish.enabled = false;
		Time.timeScale = 1;
		Application.LoadLevel (Application.loadedLevel);
		Cursor.visible = false;
		Cursor.lockState = CursorLockMode.Locked;

	}
}
