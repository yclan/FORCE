using UnityEngine;
using System.Collections;

public class TouchControl : MonoBehaviour {

	public Transform joystick;
	public Transform touchZone;
	public Transform shield;
	private Vector3 targetPos;
	private Vector3 originPos;
	private Vector3 originJoyPos;
	private Vector3 tmpJoyPos;
	private Vector3 movedVector;
	private float movedDist;
	private Vector3 zRotation;
	public float rotateVelocity;
	public float rotateAcceleration;


	void Start ()
	{
		rotateVelocity = 0.5f;
		rotateAcceleration = 100;

		targetPos = touchZone.position;
		originPos = touchZone.position;
		originJoyPos = joystick.position;

	}

	void Update()
	{
		rotateVelocity *= movedDist;
		movedVector = targetPos - originPos;//Calculate the swipe direction vector to the center
		movedDist = Vector3.Distance(targetPos, originPos);//Calculate the distance to the center
		zRotation = new Vector3(0, movedDist * Time.deltaTime * rotateAcceleration, 0);
		//Debug.Log(zRotation);

		//Control when the shield to turn right or left
		if(movedVector.x > 0)
		{
			shield.Rotate(new Vector3(0, rotateVelocity, 0) + zRotation, Space.Self);
			joystick.position += new Vector3(movedDist, movedDist, 0) * Time.deltaTime * 10;
		}
		if(movedVector.x < 0)
		{
			shield.Rotate(new Vector3(0, -rotateVelocity, 0) + zRotation*(-1f), Space.Self);
			joystick.position += new Vector3(-movedDist, -movedDist, 0) * Time.deltaTime * 10;
		}

		//Keep the joystick inside a range
		if(Vector3.Distance(joystick.position, originJoyPos) >= 1 && Vector3.Distance(joystick.position, originJoyPos) <= 1.1f)
		{
			tmpJoyPos = joystick.position;
		}
		if(Vector3.Distance(joystick.position, originJoyPos) > 1.1f){
			joystick.position = tmpJoyPos;
			//Debug.Log(tmpJoyPos);
		}
		/*
		if(targetPos.x < 4.5 || targetPos.y > -4.5)
		{
			joystick.position = tmpJoyPos;
			Debug.Log("Out of boundary");
		}
		*/
	}

	public void OnTouchDown(Vector3 point)
	{
		targetPos = new Vector3 (point.x, point.y, targetPos.z);
		rotateVelocity = 0.5f;
	}
	public void OnTouchUp()
	{
		targetPos = originPos;
		joystick.position = originJoyPos;
		rotateVelocity = 0.0f;
		//Debug.Log("Touch Up");
	}
	public void OnTouchDrag(Vector3 point)
	{
		targetPos = new Vector3 (point.x, point.y, targetPos.z);
	}
	public void OnTouchStay(Vector3 point)
	{
		rotateVelocity = 0.0f;
	}
	public void OnTouchExit()
	{
		targetPos = originPos;
		joystick.position = originJoyPos;
		Debug.Log("Touch Exit");
	}
}
