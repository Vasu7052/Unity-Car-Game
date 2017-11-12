using UnityEngine;
using System.Collections;

public class CarController : MonoBehaviour {

	public float moveSpeed;
	public float leftSpeed;
	public float rightSpeed;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		MoveObj ();

		if (Input.GetKeyDown (KeyCode.A)) {
			moveLeft ();
		}

		if (Input.GetKeyDown (KeyCode.S)) {
			moveRight ();
		}
	}

	void MoveObj() {		
		float moveAmount = Time.smoothDeltaTime * moveSpeed;
		transform.Translate ( 0f, 0f, moveAmount );	
	}

	void moveLeft(){
		float moveAmount = Time.smoothDeltaTime * leftSpeed;
		transform.Translate ( -moveAmount, 0f, 0f );	
	}

	void moveRight(){
		float moveAmount = Time.smoothDeltaTime * rightSpeed;
		transform.Translate ( moveAmount, 0f, 0f );	
	}

}
