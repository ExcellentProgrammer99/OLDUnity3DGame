using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class script : MonoBehaviour {

	public Canvas quitMenu;
	public Canvas Dzwiek;
	public Button btnStart;
	public Button btnExit;
	public Button MainMenu;
	public AudioClip win;
	public AudioSource zrodloDzwieku;
	public Canvas finish;
	public Button PlayAgain;
	public Button Next;

	/** Obiekt menu.*/
	private Canvas manuUI;

	void Start (){
		
		manuUI = (Canvas)GetComponent<Canvas>();//Pobranie menu głównego.

		quitMenu = quitMenu.GetComponent<Canvas>(); //Pobranie menu pytania o wyjście z gry.
		Dzwiek = Dzwiek.GetComponent<Canvas>();

		btnStart = btnStart.GetComponent<Button> ();//Ustawienie przycisku uruchomienia gry.
		btnExit = btnExit.GetComponent<Button> ();//Ustawienie przycisku wyjścia z gry.
		MainMenu = MainMenu.GetComponent<Button> ();
		manuUI.enabled = false;
		quitMenu.enabled = false; //Ukrycie menu z pytaniem o wyjście z gry.
		Dzwiek.enabled = false;
		finish = finish.GetComponent<Canvas> ();
		Next = Next.GetComponent<Button> ();
		PlayAgain = PlayAgain.GetComponent<Button> ();
		finish.enabled = false;
		Next.enabled = false;
		PlayAgain.enabled = false;
		Cursor.visible = false;

	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKeyUp (KeyCode.Escape)) { //Jeżeli naciśnięto klawisz "Escape"
			manuUI.enabled = !manuUI.enabled;//Ukrycie/pokazanie menu.

			Cursor.visible = manuUI.enabled;//Ukrycie pokazanie kursora myszy.

			if(manuUI.enabled) {
				Cursor.visible = true;//Pokazanie kursora.
				Time.timeScale = 0;//Zatrzymanie czasu.
				quitMenu.enabled = false; //Ukrycie menu pytania.
				btnStart.enabled = true; //Aktywacja przycsiku 'Start'.
				btnExit.enabled = true; //Aktywacja przycsiku 'Wyjście'.
				MainMenu.enabled = true;
				Dzwiek.enabled = false;
			} 

			else {
				Cursor.visible = false;//Ukrycie kursora.
				Time.timeScale = 1;//Włączenie czasu.
				quitMenu.enabled = false; //Ukrycie menu pytania.
				Dzwiek.enabled = false;
			}

		}
		else if (finish.enabled) {
			Cursor.visible = true;
			Time.timeScale = 0;
			Next.enabled = true;
			PlayAgain.enabled = true;
			quitMenu.enabled = false; //Ukrycie menu pytania.
			Dzwiek.enabled = false;
		} 
	}

	//Metoda wywoływana po naciśnięciu przycisku "Exit"
	public void PrzyciskWyjscie() {
		quitMenu.enabled = true; //Uaktywnienie meny z pytaniem o wyjście
		btnStart.enabled = false; //Deaktywacja przycsiku 'Start'.
		btnExit.enabled = false; //Deaktywacja przycsiku 'Wyjście'.
		MainMenu.enabled = false;
		Dzwiek.enabled = false;

	}

	//Metoda wywoływana podczas udzielenia odpowiedzi przeczącej na pytanie o wyjście z gry.
	public void PrzyciskNieWychodz(){
		quitMenu.enabled = false; //Ukrycie menu z pytaniem o wyjście z gry.
		btnStart.enabled = true; //Uaktywnienie przycisku 'Start'.
		btnExit.enabled = true; //Uaktywnienie przycisku 'Wyjscie'.
		MainMenu.enabled = true;
		Dzwiek.enabled = false;
	}

	//Metoda wywoływana przez przycisk uruchomienia gry 'Play Game'
	public void PrzyciskStart (){
		//Application.LoadLevel (0); //this will load our first level from our build settings. "1" is the second scene in our game  
		manuUI.enabled = false; //Ukrycie głównego menu.
		Dzwiek.enabled = false;
		Time.timeScale = 1;//Właczenie czasu.
		Cursor.visible = false;//Ukrycie kursora.
	}

	//Metoda wywoływana podczas udzielenia odpowiedzi twierdzącej na pytanie o wyjście z gry.
	public void PrzyciskTakWyjdz () {
		Application.Quit(); //Powoduje wyjście z gry.
	}
	public void PrzyciskMainMenu () {

		Application.LoadLevel(1);
	}

	public void PrzyciskDzwiek (){
		Dzwiek.enabled = true;
		quitMenu.enabled = false; //Uaktywnienie meny z pytaniem o wyjście
		btnStart.enabled = false; //Deaktywacja przycsiku 'Start'.
		btnExit.enabled = false; //Deaktywacja przycsiku 'Wyjście'.
		MainMenu.enabled = false;
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
	}
	public void PrzyciskNowyPoziom3()
	{
		finish.enabled = false;
		Time.timeScale = 1;
		Application.LoadLevel(4);
		Cursor.visible = false;
	}
	public void PrzyciskOdNowa()
	{
		finish.enabled = false;
		Time.timeScale = 1;
		Application.LoadLevel (Application.loadedLevel);


	}
}
