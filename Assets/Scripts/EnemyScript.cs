using UnityEngine;
using System.Collections;

public class EnemyScript : MonoBehaviour {
	float hp;
	float speed = 10;
	public Transform target;
	public Rigidbody2D rb;

	private GameObject dummy;
	private GameMaster gm;
	// Use this for initialization
	void Awake(){

	}

	void Start () {

		dummy = GameObject.Find ("GameObject");
		gm = dummy.GetComponent<GameMaster> ();
	}
	
	// Update is called once per frame
	void Update () {
		Movement ();
	}

	void Movement () {
		//transform.position = Vector2.MoveTowards(transform.position,
		                                         //GameObject.FindGameObjectWithTag("Player").transform.position,
		                                        // speed*Time.deltaTime);
		rb.velocity = (GameObject.FindGameObjectWithTag ("Player").transform.position - transform.position).normalized*speed;
	}

	void OnCollisionEnter2D(Collision2D col){
		if (col.gameObject.tag == "bullets") {
			Destroy (gameObject);
			Destroy (col.gameObject);
			gm.score += 1;
		}
	}

}
