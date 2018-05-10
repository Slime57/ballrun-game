﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour {

	public static bool GamePaused = false;

	public GameObject pauseMenuUI;

	void Update(){
		
		if (Input.GetKeyDown (KeyCode.Escape)) {
			if (GamePaused) {
				Resume ();
			}else{
				Pause ();
			}
		}
	}

	public void Resume(){
		pauseMenuUI.SetActive (false);
		Time.timeScale = 1f;
		GamePaused = false;
	}

	void Pause(){
		pauseMenuUI.SetActive (true);
		Time.timeScale = 0f;
		GamePaused = true;
	}

	public void LevelMenu(){
		Time.timeScale = 1f;
		SceneManager.LoadScene ("Menu");
	}

	public void Quit(){
		Application.Quit();
	}

	public void RestartLevel(){
		Time.timeScale = 1f;
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
	}
}