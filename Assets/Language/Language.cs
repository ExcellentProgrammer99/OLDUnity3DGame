using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Language : MonoBehaviour {

	public Button btnEnglish;
	public Button btnSpanish;
	public Button btnPolish;
	public AudioClip Powodzenia;
	public AudioClip GoodLuck;
	public AudioClip Spanish;
	public AudioSource zrodloDzwieku;


	/** Obiekt menu.*/
	private Canvas LanguageLOL;

	void Start (){
		LanguageLOL = (Canvas)GetComponent<Canvas>();//Pobranie menu głównego.



		btnEnglish = btnEnglish.GetComponent<Button> ();//Ustawienie przycisku uruchomienia gry.
		btnPolish = btnPolish.GetComponent<Button> ();//Ustawienie przycisku wyjścia z gry.
		btnSpanish = btnSpanish.GetComponent<Button> ();



		Time.timeScale = 0;//Zatrzymanie czasu.
		Cursor.visible = LanguageLOL.enabled;//Ukrycie pokazanie kursora myszy.
		Cursor.lockState = CursorLockMode.Confined;//Odblokowanie kursora myszy.
	}

	// Update is called once per frame
	void Update () {
	}

	//Metoda wywoływana po naciśnięciu przycisku "Exit"
	public void PrzyciskPolish() {
		LanguageLOL.enabled = false; //Ukrycie głównego menu.

		Application.LoadLevel(1);
		zrodloDzwieku.PlayOneShot (Powodzenia);

	}

	public void PrzyciskEnglish(){

		LanguageLOL.enabled = false; //Ukrycie głównego menu.

		Application.LoadLevel(2);


	}
	public void PrzyciskSpanish(){

		LanguageLOL.enabled = false; //Ukrycie głównego menu.

		Application.LoadLevel(3);



	} }
