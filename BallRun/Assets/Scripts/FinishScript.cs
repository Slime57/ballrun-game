using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishScript : MonoBehaviour {

	public float finishDelay = 3f;

	void OnTriggerEnter(){
		Invoke ("FinishLevel", finishDelay);
	}


	public void FinishLevel(){
		SceneManager.LoadScene ("LevelSelection");
		ShowVariable.LevelPoints++;
	}


}