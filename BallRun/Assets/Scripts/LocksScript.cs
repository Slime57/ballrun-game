using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LocksScript : MonoBehaviour {

	public int LevelPoints;

	// Use this for initialization
	void Start () {
		if( ShowVariable.LevelPoints >= LevelPoints){
			gameObject.SetActive (false);
		}
	}
}