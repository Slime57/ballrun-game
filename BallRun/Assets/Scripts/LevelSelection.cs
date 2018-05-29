﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelection : MonoBehaviour {
	

	public void PlayLevel1(){
		if(ShowVariable.LevelPoints == 0){
			SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
		}
	}

	public void PlayLevel2(){
		if(ShowVariable.LevelPoints == 1){
			SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
		}

	}
	public void PlayLevel3(){
		if(ShowVariable.LevelPoints == 2){
			SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 3);
		}
	}
	public void PlayLevel4(){
		if(ShowVariable.LevelPoints == 3){
			SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 4);
		}
	}


}
