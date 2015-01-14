using UnityEngine;
using System.Collections;

public class Goal : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider collider){
		collider.SendMessage("Reset");
			//GetComponent<Ball>().Reset();

		if(transform.name == "P1_Goal"){
			GameObject.FindGameObjectWithTag("score").SendMessage("P2IncreaseScore");
		}

		if(transform.name == "P2_Goal"){
			GameObject.FindGameObjectWithTag("score").SendMessage("P1IncreaseScore");
		}
	}
}
