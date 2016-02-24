using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameMaster : MonoBehaviour {
	public Text scoreText;
	
	public int score;
	// Use this for initialization
	void Start () {
		score = 0;
	}
	
	// Update is called once per frame
	void Update () {
		setScoreText (score);
	}

	void OnGUI()
	{
		GUI.Box(new Rect (10,10,100,20),"Test");
	} 

	void UpdateScore() {
		scoreText.text = "Score" + score;
	}

	void setScoreText(int skor) {
		scoreText.text = "Score : " + score.ToString ();
	}
}
