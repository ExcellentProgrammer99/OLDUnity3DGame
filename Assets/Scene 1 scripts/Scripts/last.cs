using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class last : MonoBehaviour {

	Text text;

	int sekundy = 0;

	private int sekunda = 1;
	private float timer = 0.0f;

	void Start () {
		text = GetComponent<Text> ();
	}

	void Update () {
		timer += Time.deltaTime;
		if(timer >= sekunda) {
			sekundy++;
			timer = 0.0f;
		}
		text.text = "Czas: " + sekundy;
	}
}