using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Invector.CharacterController;

public class DoctorMovement : MonoBehaviour {

	public GameObject[] obj;
	public GameObject playerController;
	private bool playerExit = false;
	
	// Update is called once per frame
	void Update () {
		if (playerExit == true) {
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
