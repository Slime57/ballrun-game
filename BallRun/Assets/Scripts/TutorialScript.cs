using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TutorialScript : MonoBehaviour {

	public Rigidbody rb;


	public Text tutorialtext;
	private string changingtext = "Welcome to CubeRun!";


	void Update(){
		tutorialtext.text = "Computer: " + changingtext;
			
		if(rb.position.z <= -20f) {
			changingtext = "You're objective is to complete the levels";
		}
	}
}