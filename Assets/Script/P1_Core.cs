using UnityEngine;
using System.Collections;

public class P1_Core : MonoBehaviour {

	public int R;
	public int G;
	public int B;

	//Use NonSerialized before the line of clarification can also make it invisible in the editor
	//[System.NonSerialized]
	public int Core_Order;

	// Use this for initialization
	void Start () {

		R = 0;
		G = 0;
		B = 0;

		Core_Order = 3;

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
