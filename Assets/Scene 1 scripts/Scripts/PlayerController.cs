using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public float speed;
	public float jumpForce=7;
	public SphereCollider collider;
	public Text countText;
	public Text winText;
	public AudioSource zrodloDzwieku;
	public AudioClip Burp;
	public LayerMask groundslayers;

	private Rigidbody rb;
	private int count;

	void Start ()
	{
		rb = GetComponent<Rigidbody>();
		count = 0;
		SetCountText ();
		winText.text = "";
		collider = GetComponent<SphereCollider> ();

	}
	private bool isGrounded()
	{
		return Physics.CheckCapsule (collider.bounds.center, new Vector3 (collider.bounds.center.x, collider.bounds.min.y, collider.bounds.center.z), collider.radius * .9f, groundslayers);
	}

	void FixedUpdate ()
	{
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");

		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);

		rb.AddForce (movement * speed);
		if (isGrounded () && Input.GetKeyDown (KeyCode.Space)) 
		{
			rb.AddForce (Vector3.up * jumpForce, ForceMode.Impulse);
		}
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
		else if (other.gameObject.CompareTag ( "Pick Up 2"))
		{
			other.gameObject.SetActive (false);
			count = count + 5;
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
}