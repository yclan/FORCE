using UnityEngine;
using System.Collections;


public class Ball : MonoBehaviour {

	public float spd = 500;
	public float speedX;
	public float speedY;
	public float spdAdjust = 1;
	public float maxSpd = 50;
	public float minSpd = 10;

	public float modSpeed = 20;


	// Use this for initialization
	void Start () {

		Reset ();
	
	}
	
	// Update is called once per frame
	void Update () {

		//Suppress the ball's velocity under maxSpd
		if(rigidbody.velocity.x > 0 && rigidbody.velocity.x >= maxSpd){
			rigidbody.AddForce(new Vector3(-spdAdjust * Time.deltaTime, 0, 0), ForceMode.Impulse);
		}
		if(rigidbody.velocity.x < 0 && rigidbody.velocity.x <= -maxSpd){
			rigidbody.AddForce(new Vector3(spdAdjust * Time.deltaTime, 0, 0), ForceMode.Impulse);
		}

//		if(rigidbody.velocity.x > 0 && rigidbody.velocity.x <= minSpd){
//			rigidbody.AddForce(new Vector3(spdAdjust/10 * Time.deltaTime, 0, 0), ForceMode.Impulse);
//		}
//		if(rigidbody.velocity.x < 0 && rigidbody.velocity.x <= -minSpd){
//			rigidbody.AddForce(new Vector3(-spdAdjust/10 * Time.deltaTime, 0, 0), ForceMode.Impulse);
//		}
	
	}

	public void Reset(){

		speedX = Random.Range(0, 2) == 0 ? -spd : spd;
		speedY = Random.Range(0, 2) == 0 ? -spd : spd;

		transform.position = new Vector3(0, 0, 0);
		//rigidbody.AddForce(new Vector3(Random.Range(150,300) * speedX * Time.deltaTime, Random.Range(150, 300) * speedY * Time.deltaTime, 0), ForceMode.VelocityChange);
		rigidbody.velocity = new Vector3(speedX * Time.deltaTime, speedY * Time.deltaTime, 0);


		//rigidbody.AddForce(new Vector3(Random.Range(speed, -speed) * Time.deltaTime, Random.Range(speed, -speed) * Time.deltaTime, 0), ForceMode.Impulse);
	}


	public void OnCollisionEnter(Collision collision){

		//When colliding with player's paddle
		if(collision.collider.tag == "p1"){

			float speedYmod = (transform.position.y - collision.transform.position.y)/6 * modSpeed;
			rigidbody.AddForce(new Vector3(2 * Time.deltaTime, speedYmod * Time.deltaTime, 0), ForceMode.Impulse);
			//Debug.Log (rigidbody.velocity.x);
		}
		if(collision.collider.tag == "p2"){

			float speedYmod = (transform.position.y - collision.transform.position.y)/6 * modSpeed;
			rigidbody.AddForce(new Vector3(-2 * Time.deltaTime, speedYmod * Time.deltaTime, 0), ForceMode.Impulse);
			//Debug.Log (rigidbody.velocity.x);
		}else{

		}

		//When colliding with walls
		if(collision.collider.tag == "wall"){
			
			//rigidbody.AddForce(new Vector3(2 * Time.deltaTime, 0, 0), ForceMode.Impulse);
			Debug.Log (rigidbody.velocity.x);
		}

	}

}
