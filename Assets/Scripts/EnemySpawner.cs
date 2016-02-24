using UnityEngine;
using System.Collections;

public class EnemySpawner : MonoBehaviour {
	public GameObject ghastly;
	// Use this for initialization
	void Start () {
		InvokeRepeating ("Spawn", 0.5f, 3f);
	}
	
	// Update is called once per frame
	void Update () {

	}

	void Spawn (){
		float x = Random.Range (-17, 17);
		float y = Random.Range (-10, 10); 
		GameObject Enemy = Instantiate (ghastly) as GameObject;
		Enemy.transform.position = new Vector2 (x, y);
		// -17 < x < 17
		// 10 < y < 10
	}
}
