using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trap : MonoBehaviour {
	Vector3 velocity = new Vector3(0.0f, 1.0f, 0.0f);
	float floorheight = 0.0f;
	float sleepThreshold = 0.05f;
	float gravity = -9.81f;

	void Start()
	{
		transform.position = new Vector3 (0.0f, 0.0f, 0.0f);
	}


	void Update () {
		transform.Rotate (new Vector3 (15, 30, 45) * Time.deltaTime);

	}
	void FixedUpdate()
	{
		if (velocity.magnitude > sleepThreshold || transform.position.y > floorheight)
		{
			velocity += new Vector3(9.0f, gravity * Time.fixedDeltaTime, 9.0f);
		}
		transform.position += velocity * Time.fixedDeltaTime;
		if (transform.position.y <= floorheight)
		{
			transform.position = new Vector3(9.0f, floorheight, 1.0f);
			velocity.y = -velocity.y;
		}
	}
}
