var myTimer : float = 59;
var text : UnityEngine.UI.Text;

function Awake() {
	text = GetComponent (UnityEngine.UI.Text);
}

function Update () {

	if(myTimer > 0){
		myTimer -= Time.deltaTime;
	}
	if(myTimer <= 0){
		Debug.Log("Koniec Gry");
	}

	text.text = "" + myTimer;
}