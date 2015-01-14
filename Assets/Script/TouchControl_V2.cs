using UnityEngine;
using System.Collections;

public class TouchControl_V2 : MonoBehaviour {

	private Vector3 finger;
	private Vector3 originPos;
	public Transform touchZone;
	public Transform shield;

	void Start ()
	{	
		//targetPos = shield.position;
		originPos = shield.position;
	}

	void Update()
	{
		shield.LookAt(finger, Vector3.back);
	}

	public void OnTouchDown(Vector3 point)
	{
		//finger = new Vector3 (point.x, point.y, shield.position.z);
		//shield.LookAt(finger, Vector3.back);
		//targetPos = new Vector3 (point.x, point.y, shield.position.z);
	}
	public void OnTouchUp()
	{
		//targetPos = originPos;
	}
	public void OnTouchDrag(Vector3 point)
	{
		finger = new Vector3 (point.x, point.y, shield.position.z);
	}
	public void OnTouchStay(Vector3 point)
	{
		//finger = new Vector3 (point.x, point.y, shield.position.z);
	}
	public void OnTouchExit()
	{
		//targetPos = originPos;
	}
}
