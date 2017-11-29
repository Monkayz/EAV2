using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoctorMovement : MonoBehaviour {

	public GameObject[] obj;
	private bool playerExit = false;
	
	// Update is called once per frame
	void Update () {
		while (playerExit == true) {
			for (int i = 0; i < obj.Length; i++) {
				obj[i].transform.position += new Vector3 (0f, 0f, -.1f);
			}
		}
	}

	void OnTriggerEnter(Collider collider){
		if (collider.tag == "Player") {
			playerExit = false;
		}
	}

	void OnTriggerExit(Collider collider){
		if (collider.tag == "Player") {
			playerExit = true;
		}
	}
}
