using UnityEngine;
using System.Collections;

public class ScoreTracker : MonoBehaviour {

	public GameObject p1GUI;
	public GameObject p2GUI;

	public int p1Score = 0;
	public int p2Score = 0;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void P1IncreaseScore(){
		p1Score++;
		p1GUI.GetComponent<TextMesh>().text = p1Score.ToString();
	}

	public void P2IncreaseScore(){
		p2Score++;
		p2GUI.GetComponent<TextMesh>().text = p2Score.ToString();
	}
}
