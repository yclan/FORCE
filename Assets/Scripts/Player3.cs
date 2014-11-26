using UnityEngine;
using System.Collections;

public class Player3 : MonoBehaviour {

	public float speed = 0;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
//		if(Input.GetKey(KeyCode.O)){
//			transform.Translate(new Vector3(0, speed * Time.deltaTime, 0));
//		}
//		if(Input.GetKey(KeyCode.L)){
//			transform.Translate(new Vector3(0, -speed * Time.deltaTime, 0));
//		}

		transform.Translate(new Vector3(0, Input.GetAxis("360_P3_Horizontal") * speed * Time.deltaTime, 0));
	
	}
}
