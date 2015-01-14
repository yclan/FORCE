using UnityEngine;
using System.Collections;

public class Joystick : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	//Set the joystick back to the most recent location when it's being dragged out of the boundary
	void OnCollisionEnter(Collision collider)
	{
		if(collider.transform.gameObject.name == "Joystick")
		{
			//joystick.position = tmpJoyPos;
			Debug.Log ("Hit the boundary!");
		}
	}
}
