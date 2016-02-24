using UnityEngine;
using System.Collections;

public class BulletLife : MonoBehaviour {
	float life;
	float age;
	// Use this for initialization
	void Start () {
		life = 0;
		age = 50;
	}
	
	// Update is called once per frame
	void Update () {
		life += 1;
		if (life >= age) 
			Destroy (gameObject);
	}

	//void OnCollisionEnter2D(Collision2D col){
	//	if (col.gameObject.tag == "enemy") {
	//		Destroy (gameObject);
	//	}
	//}
}
