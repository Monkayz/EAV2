using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorDestroyer : MonoBehaviour {

	public GameObject obj1;
	public GameObject obj2;
	public Vector3 RotateAmount;
	private bool playerNextToKey = false;

	void Update(){
		transform.Rotate (RotateAmount * Time.deltaTime);
	}
	void OnTriggerEnter(Collider collider){
		if (collider.tag == "Player") {
			Destroy (obj1);
			Destroy (obj2);
			//print("Destroyed");
		}
    }
}
