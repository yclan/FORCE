using UnityEngine;
using System.Collections;

public class TouchLogic : MonoBehaviour 
{
	public static int currTouch = 0;//so other scripts can know what touch is currently on screen
	private Ray ray;//this will be the ray that we cast from our touch into the scene
	private RaycastHit rayHitInfo = new RaycastHit();//return the info of the object that was hit by the ray
	[HideInInspector]
	public int touch2Watch = 64;
	
	void Update () 
	{
		//is there a touch on screen?
		if(Input.touches.Length <= 0)
		{
			//if no touches then execute this code
		}
		else //if there is a touch
		{
			//loop through all the the touches on screen
			for(int i = 0; i < Input.touchCount; i++)
			{
				currTouch = i;
				//Debug.Log(currTouch);

				ray = Camera.main.ScreenPointToRay(Input.GetTouch(i).position);//creates ray from screen point position
				switch(Input.GetTouch(i).phase)
				{
				case TouchPhase.Began:
					//OnTouchBeganAnywhere();
					//this.SendMessage("OnTouchBeganAnyWhere");
					if(Physics.Raycast(ray, out rayHitInfo))
						rayHitInfo.transform.gameObject.SendMessage("OnTouchBegan3D");
						//Debug.Log (rayHitInfo.transform.gameObject);
					break;
				case TouchPhase.Ended:
					//OnTouchEndedAnywhere();
					//this.SendMessage("OnTouchEndedAnywhere");
					if(Physics.Raycast(ray, out rayHitInfo))
						rayHitInfo.transform.gameObject.SendMessage("OnTouchEnded3D");
						//Debug.Log (rayHitInfo.transform.gameObject);
					break;
				case TouchPhase.Moved:
					//OnTouchMovedAnywhere();
					//this.SendMessage("OnTouchMovedAnywhere");
					if(Physics.Raycast(ray, out rayHitInfo))
						rayHitInfo.transform.gameObject.SendMessage("OnTouchMoved3D");
						//Debug.Log (rayHitInfo.transform.gameObject);
					break;
				case TouchPhase.Stationary:
					//OnTouchStayedAnywhere();
					//this.SendMessage("OnTouchStayedAnywhere");
					if(Physics.Raycast(ray, out rayHitInfo))
						rayHitInfo.transform.gameObject.SendMessage("OnTouchStayed3D");
						//Debug.Log (rayHitInfo.transform.gameObject);
					break;
				}
			}
		}
	}
}
