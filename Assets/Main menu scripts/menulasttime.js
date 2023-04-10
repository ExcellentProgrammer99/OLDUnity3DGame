var isQuitButton = false;
 	function OnMouseEnter() 
 { 
				 GetComponent.<Renderer>().material.color = Color.red; 
 } 
 	function OnMouseExit() 
 { 
 				GetComponent.<Renderer>().material.color = Color.white; 
 }
 	 function OnMouseUp() 
 {
  if( isQuitButton )
   { 
  		 Application.Quit(); 
   } 
   else 
   { 
   		Application.LoadLevel(1); 
   }
   }