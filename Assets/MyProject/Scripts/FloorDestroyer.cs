using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorDestroyer : MonoBehaviour {

	public GameObject obj1;
	public GameObject obj2;
	private bool playerNextToKey = false;

	void Update () {
		if (Input.GetKeyDown (KeyCode.E) && playerNextToKey == true) {
			Destroy (obj1);
			Destroy (obj2);
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
}
