using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelection : MonoBehaviour {
	public int LevelPoints = 0;


	public void PlayLevel1(){
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
	}
	public void PlayLevel2(){
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
	}
	public void PlayLevel3(){
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 3);
	}
	public void PlayLevel4(){
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 4);
	}
}
