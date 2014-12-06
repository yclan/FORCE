using UnityEngine;
using System.Collections;


public class Ball : MonoBehaviour {

	public float spd;
	public float dirX;
	public float dirY;
	public float spdAdjust;
	public float maxSpd;
	public float minSpd;
	public float modSpeed;


	// Use this for initialization
	void Start () {

		spd = 500;
		spdAdjust = 12;
		maxSpd = 10;
		minSpd = 9;
		modSpeed = 20;

		Reset ();
	
	}
	
	// Update is called once per frame
	void Update () {

		//Suppress the ball's velocity under maxSpd
//		if(rigidbody.velocity.x > 0 && rigidbody.velocity.x >= maxSpd){
//			rigidbody.AddForce(new Vector3(-spdAdjust * Time.deltaTime, 0, 0), ForceMode.Impulse);
//		}
//		if(rigidbody.velocity.x < 0 && rigidbody.velocity.x <= -maxSpd){
//			rigidbody.AddForce(new Vector3(spdAdjust * Time.deltaTime, 0, 0), ForceMode.Impulse);
//		}


		if(rigidbody.velocity.x > 0 && rigidbody.velocity.x <= minSpd){
			rigidbody.AddForce(new Vector3(minSpd + spdAdjust/10 * Time.deltaTime, 0, 0), ForceMode.VelocityChange);
		}
		if(rigidbody.velocity.x < 0 && rigidbody.velocity.x >= -minSpd){
			rigidbody.AddForce(new Vector3(-minSpd - spdAdjust/10 * Time.deltaTime, 0, 0), ForceMode.VelocityChange);
		}


		if(rigidbody.velocity.y > 0 && rigidbody.velocity.y <= minSpd){
			rigidbody.AddForce(new Vector3(0, minSpd + spdAdjust/10 * Time.deltaTime, 0), ForceMode.VelocityChange);
		}
		if(rigidbody.velocity.y < 0 && rigidbody.velocity.y >= -minSpd){
			rigidbody.AddForce(new Vector3(0, -minSpd - spdAdjust/10 * Time.deltaTime, 0), ForceMode.VelocityChange);
		}
	
	}

	public void Reset(){

		dirX = Random.Range(0, 2) == 0 ? -spd : spd;
		dirY = Random.Range(0, 2) == 0 ? -spd : spd;

		transform.position = new Vector3(0, 0, 0);
		rigidbody.AddForce(new Vector3(Random.Range(2, 4) * dirX * Time.deltaTime, Random.Range(1, 2) * dirY * Time.deltaTime, 0), ForceMode.VelocityChange);
		//rigidbody.velocity = new Vector3(dirX * Time.deltaTime, dirY * Time.deltaTime, 0);
		//rigidbody.AddForce(new Vector3(Random.Range(speed, -speed) * Time.deltaTime, Random.Range(speed, -speed) * Time.deltaTime, 0), ForceMode.Impulse);

		//Randomize ball's initial color
		int ranColor = Random.Range(1,4);
		Debug.Log (ranColor);
		if(ranColor == 1){
			this.renderer.material.color = Color.red;
		}else if(ranColor == 2){
			this.renderer.material.color = Color.green;
		}else{
			this.renderer.material.color = Color.blue;
		}

	}


	public void OnCollisionEnter(Collision collision){

		//When colliding with player's paddle
//		if(collision.collider.tag == "p1"){
//
//			float speedYmod = (transform.position.y - collision.transform.position.y)/6 * modSpeed;
//			rigidbody.AddForce(new Vector3(2 * Time.deltaTime, speedYmod * Time.deltaTime, 0), ForceMode.Impulse);
//			//Debug.Log (rigidbody.velocity.x);
//		}
//		if(collision.collider.tag == "p2"){
//
//			float speedYmod = (transform.position.y - collision.transform.position.y)/6 * modSpeed;
//			rigidbody.AddForce(new Vector3(-2 * Time.deltaTime, speedYmod * Time.deltaTime, 0), ForceMode.Impulse);
//			//Debug.Log (rigidbody.velocity.x);
//		}else{
//
//		}

		//When colliding with walls
		if(collision.collider.tag == "wall_R"){
			
			rigidbody.AddForce(new Vector3(-spdAdjust * Time.deltaTime, 0, 0), ForceMode.Impulse);
			Debug.Log ("VelX = " + rigidbody.velocity.x);
			Debug.Log ("VelY = " + rigidbody.velocity.y);
		}
		if(collision.collider.tag == "wall_L"){
			
			rigidbody.AddForce(new Vector3(spdAdjust * Time.deltaTime, 0, 0), ForceMode.Impulse);
			Debug.Log ("VelX = " + rigidbody.velocity.x);
			Debug.Log ("VelY = " + rigidbody.velocity.y);
		}
		if(collision.collider.tag == "wall_D"){
			
			rigidbody.AddForce(new Vector3(0, spdAdjust * Time.deltaTime, 0), ForceMode.Impulse);
			Debug.Log ("VelX = " + rigidbody.velocity.x);
			Debug.Log ("VelY = " + rigidbody.velocity.y);
		}
		if(collision.collider.tag == "wall_U"){
			
			rigidbody.AddForce(new Vector3(0, -spdAdjust * Time.deltaTime, 0), ForceMode.Impulse);
			Debug.Log ("VelX = " + rigidbody.velocity.x);
			Debug.Log ("VelY = " + rigidbody.velocity.y);
		}

		//Change Color every time hitting walls
//		if(collision.collider.tag == "wall"){
//
//			if(this.renderer.material.color == Color.red){
//				this.renderer.material.color = Color.green;
//			}else if(this.renderer.material.color == Color.green){
//				this.renderer.material.color = Color.blue;
//			}else{
//				this.renderer.material.color = Color.red;
//			}
//
//		}

	}

}
