using UnityEngine;
using System.Collections;

/**
 * Klasa bazowa po której będą dziedziczyły inne klasy.
 * Klasa będzie zawierać metody, zmienne odpowiedzialne za sterowanie całą grą.
 * 
 * @author Hubert Paluch.
 * MViRe - na potrzeby kursu UNITY3D v5.
 * mvire.com 
 */
public class Base : MonoBehaviour {

	public GameObject menu;

	/**
	 * Czy główne menu jest właczone.
	 */
	public bool isMenuOn(){
		if (menu != null) {
			Canvas manuUI = menu.GetComponent<Canvas> ();
			if (manuUI != null) {
				return manuUI.enabled;
			}
		}
		return false;
	}
}
