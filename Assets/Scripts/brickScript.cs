using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class brickScript : MonoBehaviour {

	public UiManager ui;

	// Use this for initialization
	void Start () {
		ui = GameObject.FindWithTag ("ui").GetComponent<UiManager>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnCollisionEnter2D(Collision2D col){
		if (col.gameObject.tag == "Ball") {
			Destroy (gameObject);
			ui.IncrementScore ();
		}
	}
}
