using UnityEngine;
using System.Collections;

public class Player1 : MonoBehaviour {

	public float speed = 0;
	public GameObject Bullet;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		//Keyboard
		if(Input.GetKey(KeyCode.W)){
			transform.Translate(new Vector3(0, speed * Time.deltaTime, 0));
		}
		if(Input.GetKey(KeyCode.S)){
			transform.Translate(new Vector3(0, -speed * Time.deltaTime, 0));
		}

		//360
		//rigidbody.AddForce(new Vector3(1, 0, 0), ForceMode.VelocityChange);
		transform.Translate(new Vector3(0, Input.GetAxis("360_P1_X_Axis") * speed * Time.deltaTime, 0));
		Debug.Log (Input.GetAxis("360_P1_Vertical"));

		//Shoot bullet
		if(Input.GetButtonDown("360_P1_AButton")){

			//Debug.Log ("Shoot!");
			GameObject tmpBullet = (GameObject)Instantiate(Bullet, transform.position, Quaternion.identity);
			//send message to Bullet
			tmpBullet.SendMessage("moveBullet", new Vector3(50 * Time.deltaTime, 0, 0));
			//Bullet.rigidbody.AddForce(new Vector3(1, 0, 0), ForceMode.Impulse);

		}
	
	}
}
