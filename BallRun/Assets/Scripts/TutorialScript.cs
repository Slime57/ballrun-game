using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TutorialScript : MonoBehaviour {

	public Rigidbody rb;


	public Text tutorialtext;
	private string changingtext = "Welcome to CubeRun! (Hint: Use W, A, S, and D to move!)";


	void Update(){
		tutorialtext.text = "Computer: " + changingtext;
			
		if(rb.position.z <= -20f) {
			changingtext = "You're objective is to complete the levels";
		}
		if(rb.position.z <= -40f) {
			changingtext = "However, there are obstacles. There's a bumper to your left, and a spike to your right";
		}
		if(rb.position.z <= -50f) {
			changingtext = "Good job! I was just going to mention, you should NOT touch those!";
		}
		if(rb.position.z <= -70f) {
			changingtext = "To climb a ramp, move forward in it's direction, then swerve side to side.";
		}
		if(rb.position.z <= -84f) {
			changingtext = "Great job! You're learning fast.";
		}
		if(rb.position.z <= -87f) {
			changingtext = "The last obstacle is the tube. Be watchful of your speed!";
		}
		if(rb.position.z <= -112f) {
			changingtext = "Were you surprised? The last obstacle is actually falling!";
		}
		if(rb.position.z <= -118f) {
			changingtext = "Let's see if you can beat this!";
		}
		if(rb.position.z <= -128f) {
			changingtext = "You've done great! I think you're ready.";
		}
		if(rb.position.z <= -140f) {
			changingtext = "One final tip. In regular levels, press ESCAPE to pause!";
		}
		if(rb.position.z <= -160f) {
			changingtext = "This is a goal. Make it through the hole to win! Keep moving forward to finish the tutorial.";
		}
		if(rb.position.z <= -192f) {
			changingtext = "Congradulations! Have fun!";
		}
	}
}