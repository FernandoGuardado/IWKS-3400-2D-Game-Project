using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveMaze : MonoBehaviour {

	public Transform mainCharacter;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.UpArrow) || Input.GetKeyDown (KeyCode.W)) {
			// character is walking up
			GetComponent<Rigidbody2D> ().velocity = new Vector2 (0, -3);
			mainCharacter.transform.eulerAngles = new Vector3 (0, 0, 0);
		} else if (Input.GetKeyDown (KeyCode.DownArrow) || Input.GetKeyDown (KeyCode.S)) {
			// character is walking down
			GetComponent<Rigidbody2D> ().velocity = new Vector2 (0, 3);
			mainCharacter.transform.eulerAngles = new Vector3 (0, 0, 180);
		} else if (Input.GetKeyDown (KeyCode.LeftArrow) || Input.GetKeyDown (KeyCode.A)) {
			// character is walking left
			GetComponent<Rigidbody2D> ().velocity = new Vector2 (3, 0);
			mainCharacter.transform.eulerAngles = new Vector3 (0, 0, 90);
		} else if (Input.GetKeyDown (KeyCode.RightArrow) || Input.GetKeyDown (KeyCode.D)) {
			// character is walking left
			GetComponent<Rigidbody2D> ().velocity = new Vector2 (-3, 0);
			mainCharacter.transform.eulerAngles = new Vector3 (0, 0, -90);
		} else if (Input.GetKeyDown (KeyCode.RightArrow) || Input.GetKeyDown (KeyCode.E)) {
			// character attempts to pick something up from current map location
		} else {
			// stop character from moving
			GetComponent<Rigidbody2D> ().velocity = new Vector2 (0, 0);
		}

	}
}
