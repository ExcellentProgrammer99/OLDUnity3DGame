using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Player3 : MonoBehaviour {

	public float speed;
	public Text countText;
	public Text winText;
	public AudioSource zrodloDzwieku;
	public AudioClip Burp;
	public AudioClip hurt;

	private Rigidbody rb;
	private int count;

	void Start ()
	{
		rb = GetComponent<Rigidbody>();
		count = 0;
		SetCountText ();
		winText.text = "";
	}

	void FixedUpdate ()
	{
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");

		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);

		rb.AddForce (movement * speed);
	}

	void OnTriggerEnter(Collider other) 
	{
		if (other.gameObject.CompareTag ( "Pick Up"))
		{
			other.gameObject.SetActive (false);
			count = count + 1;
			SetCountText ();

			if (zrodloDzwieku != null) {
				zrodloDzwieku.PlayOneShot (Burp);
			}
		}
	}

	void SetCountText ()
	{
		countText.text = "Licznik: " + count.ToString () + "/33";
		if (count >= 33)
		{
			winText.text = "Congratulations, moron You Win!";
			Time.timeScale = 0;

		}
	}
	void OnTrigger(Collider other) 
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