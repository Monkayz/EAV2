using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorDestroyer : MonoBehaviour {

	public GameObject obj1;
	public GameObject obj2;
	private bool playerNextToKey = false;

	void OnTriggerEnter(Collider collider){
		if (collider.tag == "Player") {
			Destroy (obj1);
			Destroy (obj2);
			//print("Destroyed");
		}
    }
}
