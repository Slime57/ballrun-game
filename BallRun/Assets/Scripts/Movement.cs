﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

	public Rigidbody rb;

	public float moveforce = 800f;

	void FixedUpdate () {



		if(Input.GetKey("a")){
			rb.AddForce(moveforce * Time.deltaTime, 0, 0);
		}

		if(Input.GetKey("d")){
			rb.AddForce(-moveforce * Time.deltaTime, 0, 0);
		}
			
		if(Input.GetKey("w")){
			rb.AddForce(0, 0, -moveforce * Time.deltaTime);
		}

		if(Input.GetKey("s")){
			rb.AddForce(0, 0, moveforce * Time.deltaTime);
		}


		if (rb.position.y < -2) {
			FindObjectOfType<GameManager> ().Endgame ();
		}
	}
}
