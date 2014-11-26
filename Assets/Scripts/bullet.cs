using UnityEngine;
using System.Collections;

public class bullet : MonoBehaviour {

	private Vector3 initialDir = new Vector3(0, 0 ,0);
	public bool isShot = false;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.position += initialDir;
		//rigidbody.AddForce(initialDir, ForceMode.Impulse);
		if(transform.position.x >= 20){
			isShot = false;
		}
	}

	void moveBullet(Vector3 dir){

		if(!isShot){
			initialDir = dir;
			isShot = true;
			Debug.Log (isShot);
		}

	}

//	public void wait(){
//		isShot = true;
//		//yield return new WaitForSeconds (waitTime);
//	}
}
