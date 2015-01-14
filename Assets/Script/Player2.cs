using UnityEngine;
using System.Collections;

public class Player2 : MonoBehaviour {

	public float speed = 0;
	public GameObject Bullet;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {

		//Keyboard
		if(Input.GetKey(KeyCode.O)){
			transform.Translate(new Vector3(0, speed * Time.deltaTime, 0));
		}
		if(Input.GetKey(KeyCode.L)){
			transform.Translate(new Vector3(0, -speed * Time.deltaTime, 0));
		}

		//360
		transform.Translate(new Vector3(0, Input.GetAxis("360_P2_Vertical") * speed * Time.deltaTime, 0));

		//Shoot bullet
		if(Input.GetButtonDown("360_P2_AButton")){
			
			//Debug.Log ("Shoot!");
			GameObject tmpBullet = (GameObject)Instantiate(Bullet, transform.position, Quaternion.identity);
			//send message to Bullet
			tmpBullet.SendMessage("moveBullet", new Vector3(-50 * Time.deltaTime, 0, 0));
			//Bullet.rigidbody.AddForce(new Vector3(1, 0, 0), ForceMode.Impulse);
			
		}
	
	}

}
