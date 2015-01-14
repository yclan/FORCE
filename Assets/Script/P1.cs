using UnityEngine;
using System.Collections;

public class P1 : MonoBehaviour {

	public Transform target;
	public Vector3 worldUp = Vector3.down;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		this.transform.LookAt(target, worldUp);
	
	}
}
