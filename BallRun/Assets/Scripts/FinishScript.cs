using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishScript : MonoBehaviour {

	public float finishDelay = 3f;

	void OnCollisionEnter(){
		Invoke ("FinishLevel", finishDelay);
	}


	void FinishLevel(){
		SceneManager.LoadScene ("LevelSelection");
	}


}