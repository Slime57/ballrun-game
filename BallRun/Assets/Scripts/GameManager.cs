using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

	bool gameHasEnded = false;

	public void Endgame() {
		if (gameHasEnded == false) {
			gameHasEnded = true;
			Debug.Log ("GAME OVER");
			Restart ();
		}
	}

	public void Restart(){
		SceneManager.LoadScene (SceneManager.GetActiveScene ().name);
	}
}
