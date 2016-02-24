using UnityEngine;
using System.Collections;

public class ExampleCode : MonoBehaviour{
	public GameObject bullet;
	public float speed;
	public float bulletSpeed;

	private AnotherObject anotherbject;
	// Use this for initialization
	void Start () {
		anotherbject = GetComponent<AnotherObject> ();
		//Debug.Log (anotherbject.iniPublic);
	}
	
	// Update is called once per frame

	void Update () {

		Inputs ();
		FacingMouse ();
	}

	void Inputs(){
		float translationX = Input.GetAxisRaw ("Horizontal") * speed;
		float translationY = Input.GetAxisRaw ("Vertical") * speed;
		translationX *= Time.deltaTime;
		translationY *= Time.deltaTime;

		transform.Translate (translationX, translationY, 0, Space.World);

		if(Input.GetMouseButtonDown(0)){
			Fire ();
		}
	}

	float GetMouseAngle(){
		Vector3 pos = Camera.main.WorldToScreenPoint(transform.position);
		Vector3 dir = Input.mousePosition - pos;
		float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
		return angle;
	}

	void FacingMouse(){
		transform.rotation = Quaternion.AngleAxis(GetMouseAngle() - 90f, Vector3.forward); 
	}

	void Fire(){
		GameObject energyBall = Instantiate (bullet) as GameObject;
		energyBall.transform.position = transform.position;
		energyBall.transform.rotation = Quaternion.AngleAxis(GetMouseAngle(), Vector3.forward);
		energyBall.GetComponent<Rigidbody2D>().AddForce (energyBall.transform.right * bulletSpeed);
	}


}
