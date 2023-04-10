using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ScoreManager : MonoBehaviour {

	public static int score;

	public static int highscore;

	Text text;
public class highscore : MonoBehaviour {

	// Use this for initialization
	void Start () { 
			text = GetComponent<Text> (); 

			score = 0;

			highscore = PlayerPrefs.GetInt ("highscore", highscore);
			text.text = highscore.ToString();
		
		
	}
	
	// Update is called once per frame
	void Update () {     if (score > highscore){
			highscore = score;
			text.text = "" + score;

			PlayerPrefs.SetInt ("highscore", highscore);
			};
			public static void AddPoints (int pointsToAdd)
			{
				score += pointsToAdd;
			}

			public static void Reset()
			{
				score = 0;
			}
		
	}
	void OnDestroy()
	{
		PlayerPrefs.SetInt ("highscore", highscore);
		PlayerPrefs.Save();
	}
}
