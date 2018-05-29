using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TutorialScript : MonoBehaviour {


	public Text tutorialtext;
	private string changingtext = "Welcome to CubeRun!";

	void Start(){
		tutorialtext.text = "Computer:" + changingtext;
	}


}
