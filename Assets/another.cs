using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class another : MonoBehaviour {

	public Canvas Tworcy;
	public Canvas Ustawienia;
	public Canvas Kontynuuj;
	public Button btnStart;
	public Button btnExit;
	public Button btnlevel2;

	public Button MainMenu;

	/** Obiekt menu.*/
	private Canvas manuUI;

	void Start (){
		manuUI = (Canvas)GetComponent<Canvas>();//Pobranie menu głównego.
		Tworcy = Tworcy.GetComponent<Canvas>(); //Pobranie menu pytania o wyjście z gry.
		Ustawienia = Ustawienia.GetComponent<Canvas>();
		Kontynuuj = Kontynuuj.GetComponent<Canvas>();


		btnStart = btnStart.GetComponent<Button> ();//Ustawienie przycisku uruchomienia gry.
		btnExit = btnExit.GetComponent<Button> ();//Ustawienie przycisku wyjścia z gry.
		btnlevel2 = btnlevel2.GetComponent<Button> ();
		MainMenu = MainMenu.GetComponent<Button> ();

		Tworcy.enabled = false; //Ukrycie menu z pytaniem o wyjście z gry.
		Ustawienia.enabled = false;
		Kontynuuj.enabled = false;
		Time.timeScale = 0;//Zatrzymanie czasu.
		Cursor.visible = manuUI.enabled;//Ukrycie pokazanie kursora myszy.
	}

	// Update is called once per frame
	void Update () {
	}

	//Metoda wywoływana po naciśnięciu przycisku "Exit"
	public void PrzyciskWyjscie() {
		Tworcy.enabled = true; //Uaktywnienie meny z pytaniem o wyjście
		btnStart.enabled = false; //Deaktywacja przycsiku 'Start'.
		btnExit.enabled = false; //Deaktywacja przycsiku 'Wyjście'.
		Ustawienia.enabled = false;
		Kontynuuj.enabled = false;
		btnlevel2.enabled = false;

	}

	public void PrzyciskLevel2(){
		
		manuUI.enabled = false; //Ukrycie głównego menu.
		Time.timeScale = 1;//Właczenie czasu.

		Application.LoadLevel(3);
		Cursor.visible = false;//Ukrycie kursora.

	}
	

	//Metoda wywoływana podczas udzielenia odpowiedzi przeczącej na pytanie o wyjście z gry.
	public void PrzyciskNieWychodz(){
		Tworcy.enabled = false; //Ukrycie menu z pytaniem o wyjście z gry.
		btnStart.enabled = true; //Uaktywnienie przycisku 'Start'.
		btnExit.enabled = true; //Uaktywnienie przycisku 'Wyjscie'.
		Ustawienia.enabled = false;
		Kontynuuj.enabled = false;
		btnlevel2.enabled = false;


	}

	//Metoda wywoływana przez przycisk uruchomienia gry 'Play Game'
	public void PrzyciskStart (){
		//Application.LoadLevel (0); //this will load our first level from our build settings. "1" is the second scene in our game  
		manuUI.enabled = false; //Ukrycie głównego menu.
		Time.timeScale = 1;//Właczenie czasu.

		Application.LoadLevel(2);
		Cursor.visible = false;//Ukrycie kursora.
	}

	//Metoda wywoływana podczas udzielenia odpowiedzi twierdzącej na pytanie o wyjście z gry.
	public void PrzyciskTakWyjdz () {
		Application.Quit(); //Powoduje wyjście z gry.

	}
	public void PrzyciskTworcy(){
		Ustawienia.enabled = false;
		Tworcy.enabled = false; //Ukrycie menu z pytaniem o wyjście z gry.
		btnStart.enabled = false; //Uaktywnienie przycisku 'Start'.
		btnExit.enabled = false; //Uaktywnienie przycisku 'Wyjscie'.
		Kontynuuj.enabled = false;
		btnlevel2.enabled = false;
	}
	public void PrzyciskMainMenu () {
		Ustawienia.enabled = false;
		Tworcy.enabled = false; //Ukrycie menu z pytaniem o wyjście z gry.
		btnStart.enabled = true; //Uaktywnienie przycisku 'Start'.
		btnExit.enabled = true; //Uaktywnienie przycisku 'Wyjscie'.
		Kontynuuj.enabled = false;
		btnlevel2.enabled = false;

	}

	public void PrzyciskUstawienia() {
		Ustawienia.enabled = true;
		Tworcy.enabled = false; //Uaktywnienie meny z pytaniem o wyjście
		btnStart.enabled = false; //Deaktywacja przycsiku 'Start'.
		btnExit.enabled = false; //Deaktywacja przycsiku 'Wyjście'.
		Kontynuuj.enabled = false;
		btnlevel2.enabled = false;

	}
	public void PrzyciskKontynuuj() {
		Ustawienia.enabled = false;
		Tworcy.enabled = false; //Uaktywnienie meny z pytaniem o wyjście
		btnStart.enabled = false; //Deaktywacja przycsiku 'Start'.
		btnExit.enabled = false; //Deaktywacja przycsiku 'Wyjście'.
		Kontynuuj.enabled = true;
		btnlevel2.enabled = true;
}
}