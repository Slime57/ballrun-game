using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

	bool gameHasEnded = false;

	public float restartDelay = 2f;

	public void Endgame() {
		if (gameHasEnded == false) {
			gameHasEnded = true;
			Debug.Log ("GAME OVER");
			Invoke ("Restart", restartDelay);
		}
	}

	public void Restart(){
		SceneManager.LoadScene (SceneManager.GetActiveScene ().name);
	}
}
