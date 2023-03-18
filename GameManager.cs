using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

	public int score;
	public Text scoreDisplay;
	public Text endGame;

	// Use this for initialization
	void Start () {
		score = 0;
		SetScore ();
		endGame.text = "";
	}

	void Update(){
		if (Input.GetKeyDown (KeyCode.Space)) {
			SceneManager.LoadScene (SceneManager.GetActiveScene ().name);
		}
	}
		
	public void SetScore(){

		scoreDisplay.text = "Score: " + score.ToString ();
		if(score>=3){
			endGame.text = "Game Over";
		}

	}
}
