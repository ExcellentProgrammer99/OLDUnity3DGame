using UnityEngine;
using UnityEngine.UI;
using System.Collections;

/**
 * Skrypt zdrowia.
 * Jezeli obiekt ma ten skrypt to znaczy, że ma zdrowie ktore mozna mu zabrać.
 * 
 * @author Hubert Paluch.
 * MViRe - na potrzeby kursu UNITY3D v5.
 * mvire.com 
 */
public class Zdrowie : MonoBehaviour {

	//Punkty zdrowia.
	public int zdrowie = 100;

	/** 
	 * Punkty zdrowia wyświetlane na ekranie.
	 * http://docs.unity3d.com/ScriptReference/UI.Text.html
	 */
	public Text zdrowieUI;
	/**Obrazek obrażeń (błysk).*/
	public Image obrazeniaImage;
	/** Czas podczas którego będzie wyświetlany obrazek obrażeń.*/
	private float flashSpeed = 5f;
	/** Kolor obrażeń.*/
	public Color flashColor = new Color (1f, 0f, 0f, 0.1f); 

	/** Flaga z informacia czy zadano obrażenia.*/
	private bool zadanoObrazenia = false;

	//Zadanie obrażeń.
	public void otrzymaneObrazenia(float obrazenia) {
		zadanoObrazenia = true;
		//Jeżeli zdrowie większe od zera to można zadać obrażenia.
		if (zdrowie > 0) {
			//Odięcie od zdrowia punktów zadanych obrażeń.
			zdrowie -= (int)obrazenia;
			if(zdrowie < 0){
				zdrowie = 0;
			}
			setZdrwieUI();
		}

		//Jeżeli zdrowie równe zero to obiekt do usunięcia.
		/*if(zdrowie <=0){
			Die();
		}*/	
	}

	void Update(){
		if (zadanoObrazenia && obrazeniaImage != null) {
			obrazeniaImage.color = flashColor;
			zadanoObrazenia = false;
		} else if(obrazeniaImage != null){
			obrazeniaImage.color = Color.Lerp(obrazeniaImage.color, Color.clear, flashSpeed * Time.deltaTime);
			zadanoObrazenia = false;
		}
	}

	public void Die(){
		Destroy(gameObject);	
	}

	/**
	 * Funkcja zwraca informację o tym czy obiekt posiadający zdrowie ciągle żyje.
	 * Jeżeli obiekt żyje to zwraca 'false' w przeciwnym razie 'true'.
	 */
	public bool czyMartwy(){
		if (zdrowie <= 0) {
			return true;
		}
		return false;
	}

	/**
	 * Metoda ustawia tekst wyświetlający punkty zdrowia.
	 */
	private void setZdrwieUI(){
		if (zdrowieUI != null) {

			zdrowieUI.text = zdrowie.ToString ();
		}
	}

}
