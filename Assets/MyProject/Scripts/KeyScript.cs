using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class KeyScript : MonoBehaviour {
	public GameObject key;
	private bool playerNextToKey = false;

	void Update () {
		if (Input.GetKeyDown (KeyCode.E) && playerNextToKey == true) {
			key.active = false;
		}
	}
		
	void OnTriggerEnter(Collider collider){
		if (collider.tag == "Player") {
			playerNextToKey = true;
		}
	}

	void OnTriggerExit(Collider collider){
		if (collider.tag == "Player") {
			playerNextToKey = false;
		}
	}

	void OnGUI(){
		if (playerNextToKey) {
			GUI.Box (new Rect (0, 35, 200, 25), "Press E to pickup");
		}
	}
}
