using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIEnemy : MonoBehaviour {

	public float targetDistance;
	public float enemyLookDistance;
	public float enemyAttackDistance;
	public float enemyMovementSpeed;
	public float damping;
	public float playerHealth;
	public Transform thirdPersonTarget;
	Rigidbody theRigidBody;
	Renderer myRender;

	// Use this for initialization
	void Start () {
		myRender = GetComponent<Renderer> ();
		theRigidBody = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		targetDistance = Vector3.Distance (thirdPersonTarget.position, transform.position);
		if (targetDistance < enemyLookDistance) {
			myRender.material.color = Color.yellow;
			lookAtPlayer ();
		}
		if (targetDistance < enemyAttackDistance) {
			myRender.material.color = Color.red;
			attackPlease ();
			print("attack");
		} else {
			myRender.material.color = Color.blue;
		}
	}

	void lookAtPlayer(){
		Quaternion rotation = Quaternion.LookRotation (thirdPersonTarget.position - transform.position);
		transform.rotation = Quaternion.Slerp (transform.rotation, rotation, Time.deltaTime * damping);
	}

	void attackPlease(){
		theRigidBody.AddForce (transform.forward * enemyMovementSpeed);
	}
	void OnCollisionEnter(Collision col){
		if (col.gameObject.name == "Player") {
			Destroy (col.gameObject);
			print ("DED");
		}
	}
}
