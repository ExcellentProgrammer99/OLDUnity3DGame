using UnityEngine;
using UnityEngine.UI;
using System.Collections;

/**
 * Skrypt odpowiedzialny za zwykonanie ataku przez gracza.
 * 
 * @author Hubert Paluch.
 * MViRe - na potrzeby kursu UNITY3D v5.
 * mvire.com 
 */
public class GraczAtak : MonoBehaviour {

	/** Typ ataku przeciwnika.*/
	public enum TypAtaku { Kamien, Rakieta, Pistolet};
	/** Typy ataków jakie może wykonać przecisnik.*/
	public TypAtaku typAtaku = TypAtaku.Kamien;

	public Image wybranaBron;
	public Sprite kamien;
	public Sprite pocisk;
	public Sprite rakieta;

	private StrzalPistolet strzalPistolet;
	private StrzalKamieniem strzalKamien;
	private StrzalRakieta strzalRakieta;

	void Start () {
		strzalPistolet = (StrzalPistolet) GetComponent<StrzalPistolet>();
		strzalKamien = (StrzalKamieniem) GetComponent<StrzalKamieniem>();
		strzalRakieta = (StrzalRakieta) GetComponent<StrzalRakieta>();
	}

	void Update () {
		wybierzBron ();
		if (Input.GetMouseButton (0)) {
			wykonajStrzal();
		}
	}

	/**
	 * Wykonuje atak.
	 */
	public void wykonajStrzal(){
		switch (typAtaku) {
			case TypAtaku.Kamien: //Atak pociskiem
				if (strzalKamien != null) {
					strzalKamien.strzal ();
				}
				break;
			case TypAtaku.Rakieta:
				if (strzalRakieta != null) {
					strzalRakieta.strzal ();
				}
				break;		
			case TypAtaku.Pistolet:
				if (strzalPistolet != null) {
					strzalPistolet.strzal ();
				}
				break;		
		}
	}

	/**
	* Wybor broni.
	*/
	private void wybierzBron(){
		if (Input.GetKeyDown(KeyCode.Alpha1)) {
			typAtaku = TypAtaku.Kamien;
			//GetComponent<Sprite>().image
			wybranaBron.overrideSprite  = kamien;

		} else if(Input.GetKeyDown(KeyCode.Alpha2)){
			typAtaku = TypAtaku.Pistolet;
			wybranaBron.overrideSprite  = pocisk;
		}else if(Input.GetKeyDown(KeyCode.Alpha3)){
			typAtaku = TypAtaku.Rakieta;
			wybranaBron.overrideSprite  = rakieta;
		}

	}

}
