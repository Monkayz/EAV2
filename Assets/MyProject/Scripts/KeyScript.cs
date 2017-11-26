using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class KeyScript : MonoBehaviour {
	public GameObject key;
	public GameObject keyUI;
	private bool playerNextToKey = false;

	void Update () {
		if (Input.GetKeyDown (KeyCode.E) && playerNextToKey == true) {
            key.SetActive(false);
			keyUI.SetActive (true);
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
