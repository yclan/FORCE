using UnityEngine;
using System.Collections;

public class TouchLogic : MonoBehaviour 
{
	public LayerMask touchInputMask;

	private Ray ray;//this will be the ray that we cast from our touch into the scene

	//private List<GameObject> touchList = new List<GameObject>();
	//private GameObject[] touchesOld;
	
	void Update () 
	{
		if(Input.touchCount > 0)
		{
			//touchesOld = new GameObject[touchList.Count];
			//touchList.CopyTo(touchesOld);
			//touchList.Clear();

			foreach (Touch touch in Input.touches)
			{
				ray = camera.ScreenPointToRay(touch.position);
				RaycastHit rayHit;

				if(Physics.Raycast(ray, out rayHit, touchInputMask))
				{
					GameObject recipient = rayHit.transform.gameObject;

					if(touch.phase == TouchPhase.Began)
					{
						recipient.SendMessage("OnTouchDown", rayHit.point, SendMessageOptions.DontRequireReceiver);
					}
					if(touch.phase == TouchPhase.Ended)
					{
						recipient.SendMessage("OnTouchUp", rayHit.point, SendMessageOptions.DontRequireReceiver);
					}
					if(touch.phase == TouchPhase.Stationary || touch.phase == TouchPhase.Moved)
					{
						recipient.SendMessage("OnTouchStay", rayHit.point, SendMessageOptions.DontRequireReceiver);
					}
					if(touch.phase == TouchPhase.Canceled)
					{
						recipient.SendMessage("OnTouchExit", rayHit.point, SendMessageOptions.DontRequireReceiver);
					}
				}
			}
			/*
			foreach (GameObject g in touchesOld)
			{
				if(!touchList.Contains(g))
					g.SendMessage("OnTouchExit", rayHit.point, SendMessageOptions.DontRequireReceiver);
			}
			*/
		}
	}
}
