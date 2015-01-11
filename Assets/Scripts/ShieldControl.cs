using UnityEngine;
using System.Collections;

public class ShieldControl : TouchLogic {

	public float speed = 10f;
	private Vector3 finger;
	private Transform myTrans, camTrans;
	
	void Start ()
	{
		myTrans = this.transform;
		camTrans = Camera.main.transform;
	}
	
	//separated to own function so it can be called from multiple functions
	void LookAtFinger()
	{
		//Debug.Log ("Ray hits the shield!");
		//myTrans.Translate (Vector3.forward * speed * Time.deltaTime);
		//z of ScreenToWorldPoint is distance from camera into the world, so we need to find this object's distance from the camera to make it stay on the same plane
		Vector3 tempTouch = new Vector3(Input.GetTouch(touch2Watch).position.x, Input.GetTouch(touch2Watch).position.y, 
		                                camTrans.position.z - myTrans.position.z);
		//Convert screen to world space
		finger = Camera.main.ScreenToWorldPoint(tempTouch);
		
		//look at finger position
		myTrans.LookAt(finger, Vector3.back);
		//this.transform.parent.transform.LookAt(finger, Vector3.forward);
	}
	public void OnTouchMoved3D()
	{
		LookAtFinger();
	}
	public void OnTouchStayed3D()
	{
		LookAtFinger();
	}
	public void OnTouchBegan3D()
	{
		touch2Watch = TouchLogic.currTouch;
	}
}
