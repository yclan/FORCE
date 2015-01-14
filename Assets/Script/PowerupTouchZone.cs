using UnityEngine;
using System.Collections;
using HutongGames.PlayMaker;

public class PowerupTouchZone : MonoBehaviour {

	public GameObject AudioController;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void OnTouchDown()
	{
		PlayMakerFSM.BroadcastEvent("usePowerup");
		AudioController.SendMessage("playUsePowerUp", SendMessageOptions.DontRequireReceiver);
		//Debug.Log("Powerup Touched!");
	}
}
