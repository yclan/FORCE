using UnityEngine;
using System.Collections;

public class TouchControl : MonoBehaviour {

	//public Transform joystick;
	public Transform touchZone;
	public Transform shield;
	private Vector3 targetPos;
	private Vector3 originPos;
	private Vector3 movedVector;
	private float movedDist;
	private Vector3 zRotation;
	public float rotateSpeed;

	void Start ()
	{
		targetPos = touchZone.position;
		originPos = touchZone.position;
	}

	void Update()
	{
		movedVector = targetPos - originPos;//Calculate the swipe direction vector to the center
		movedDist = Vector3.Distance(targetPos, originPos);//Calculate the distance to the center
		zRotation = new Vector3(0, movedDist * Time.deltaTime * rotateSpeed, 0);
		//Debug.Log(zRotation);

		if(movedVector.x >= 0)
		{
			//replace with the +angle of SHIELD!
			shield.Rotate(new Vector3(0, 1, 0) + zRotation, Space.Self);
			//joystick.position += new Vector3(movedDist, movedDist, 0) * Time.deltaTime;
		}else{
			//replace with the -angle of SHIELD!
			shield.Rotate(new Vector3(0, -1, 0)  - zRotation, Space.Self);
			//joystick.position -= new Vector3(movedDist, movedDist, 0) * Time.deltaTime;
		}
	}
	
	public void OnTouchDown(Vector3 point)
	{
		targetPos = new Vector3 (point.x, point.y, targetPos.z);
	}
	public void OnTouchUp()
	{
		targetPos = originPos;
		Debug.Log("Touch Up");
	}
	public void OnTouchStay(Vector3 point)
	{
		targetPos = new Vector3 (point.x, point.y, targetPos.z);
	}
	public void OnTouchExit()
	{
		targetPos = originPos;
		Debug.Log("Touch Exit");
	}
}
