using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LocksScript : MonoBehaviour {

	public GameObject objectToDisable;

	// Use this for initialization
	void Start () {
		if( ShowVariable.LevelPoints >= 1){
			objectToDisable.SetActive (false);
	}
}
