﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballScript : MonoBehaviour {

	public Rigidbody2D rb;
	public float ballForce;
	bool gameStarted=false;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyUp (KeyCode.Space) && gameStarted==false) {
			transform.SetParent(null);
			rb.isKinematic = false;

			rb.AddForce (new Vector3 (ballForce, ballForce));
			gameStarted = true;
		}
	}
}
