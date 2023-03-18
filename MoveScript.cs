using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveScript : MonoBehaviour {

	public float speed = 10.0f;
	private Rigidbody rb;
	private GameManager gm;
	
	// Use this for initialization
	void Start () {
		rb = GetComponent <Rigidbody> ();
		GameObject theScore = GameObject.Find ("GameManager");
		gm = theScore.GetComponent <GameManager> ();
	}
	
	// Update is called once per frame
	void Update () {
		float moveHorizontal = Input.GetAxis("Horizontal");
		float moveVertical = Input.GetAxis("Vertical");

		Vector3 movement = new Vector3(moveHorizontal,0.0f,moveVertical);
		rb.AddForce(movement*speed);
	}

	void OnTriggerEnter(Collider other){
		if(other.gameObject.tag == "Pick Up"){
			other.gameObject.SetActive (false);

			gm.score = gm.score + 1;
			gm.SetScore ();
		}
	}
}
