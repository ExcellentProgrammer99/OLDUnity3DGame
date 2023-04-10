#pragma strict
import UnityEngine.UI;

var tekst:Text;

var czas:int;

function Update () {
czas=Time.fixedTime;

tekst.text= czas.ToString("f0");


}
function onGUI () {


czas=Time.fixedTime;
if(Input.GetButtonDown("RESTART"))
	czas = 0;
}