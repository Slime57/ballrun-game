using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

	public Rigidbody rb;

	public float moveforce = 400;

	void FixedUpdate () {

		rb.AddForce (0, 0, -moveforce * Time.deltaTime);

		if(Input.GetKey("a")){
			rb.AddForce(moveforce * Time.deltaTime, 0, 0);
		}

		if(Input.GetKey("d")){
			rb.AddForce(-moveforce * Time.deltaTime, 0, 0);
		}
			
	}
}
