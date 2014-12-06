using UnityEngine;
using System.Collections;


public class Triangle : MonoBehaviour {

	public GameObject CORE;

	public GameObject CORE_1;
	public GameObject CORE_2;
	public GameObject CORE_3;

	public int Core_Order;

	// Use this for initialization
	void Start () {

		Core_Order = 3;
	}
	
	// Update is called once per frame
	void Update () {

		//Debug.Log (CORE.GetComponent<P1_Core>().R);
	
	}

	void OnCollisionEnter(Collision collider){

		//Debug.Log (collider.gameObject.renderer.material.name);
		//Debug.Log (this.transform.parent.Find ("Mesh").gameObject.renderer.material.name);

		if(this.transform.parent.Find ("Mesh").gameObject.renderer.material.name != collider.gameObject.renderer.material.name){
			this.transform.parent.gameObject.SetActive(false);
	
		}else{


			if(Core_Order == 3){


				//Debug.Log (collider.gameObject.renderer.material.name);

				if(collider.gameObject.renderer.material.name == "Mat_R (Instance)"){
					CORE_3.renderer.material.color = Color.red;
					CORE.GetComponent<P1_Core>().R += 1;
					Debug.Log ("R = " + CORE.GetComponent<P1_Core>().R);
				}
				if(collider.gameObject.renderer.material.name == "Mat_G (Instance)"){
					CORE_3.renderer.material.color = Color.green;
					CORE.GetComponent<P1_Core>().G += 1;
					Debug.Log ("G = " + CORE.GetComponent<P1_Core>().G);
				}
				if(collider.gameObject.renderer.material.name == "Mat_B (Instance)"){
					CORE_3.renderer.material.color = Color.blue;
					CORE.GetComponent<P1_Core>().B += 1;
					Debug.Log ("B = " + CORE.GetComponent<P1_Core>().B);
				}

				Debug.Log("Core Order = " + Core_Order);
				
			}

			if(Core_Order == 2){
				
				if(collider.gameObject.renderer.material.name == "Mat_R (Instance)"){
					CORE_2.renderer.material.color = Color.red;
					CORE.GetComponent<P1_Core>().R += 1;
					Debug.Log ("R = " + CORE.GetComponent<P1_Core>().R);
				}
				if(collider.gameObject.renderer.material.name == "Mat_G (Instance)"){
					CORE_2.renderer.material.color = Color.green;
					CORE.GetComponent<P1_Core>().G += 1;
					Debug.Log ("G = " + CORE.GetComponent<P1_Core>().G);
				}
				if(collider.gameObject.renderer.material.name == "Mat_B (Instance)"){
					CORE_2.renderer.material.color = Color.blue;
					CORE.GetComponent<P1_Core>().B += 1;
					Debug.Log ("B = " + CORE.GetComponent<P1_Core>().B);
				}

				Debug.Log("Core Order = " + Core_Order);
				
			}

			if(Core_Order == 1){
	
				if(collider.gameObject.renderer.material.name == "Mat_R (Instance)"){
					CORE_1.renderer.material.color = Color.red;
					CORE.GetComponent<P1_Core>().R += 1;
					Debug.Log ("R = " + CORE.GetComponent<P1_Core>().R);
				}
				if(collider.gameObject.renderer.material.name == "Mat_G (Instance)"){
					CORE_1.renderer.material.color = Color.green;
					CORE.GetComponent<P1_Core>().G += 1;
					Debug.Log ("G = " + CORE.GetComponent<P1_Core>().G);
				}
				if(collider.gameObject.renderer.material.name == "Mat_B (Instance)"){
					CORE_1.renderer.material.color = Color.blue;
					CORE.GetComponent<P1_Core>().B += 1;
					Debug.Log ("B = " + CORE.GetComponent<P1_Core>().B);
				}

				Debug.Log("Core Order = " + Core_Order);
				Core_Order = 4;
				powerUP(CORE.GetComponent<P1_Core>().R, CORE.GetComponent<P1_Core>().G, CORE.GetComponent<P1_Core>().B);
				
			}

			Core_Order -= 1;

		}

	}

	public void powerUP(int r, int g, int b){

		CORE_1.renderer.material.color = Color.white;
		CORE_2.renderer.material.color = Color.white;
		CORE_3.renderer.material.color = Color.white;
		
		if(r != 3 && g != 3 && b != 3 && (r == 0 || g == 0 || b == 0)){
			//60% chance of getting a random color block back
			Debug.Log ("Get a Color Block");
			
		}else{
			
			//40% chance of getting a power up
			if(r == 1 && g == 1 && b == 1){
				//Get a blocking shield
				Debug.Log ("Get a Blocking Shield");
				//CORE_1.renderer.material.SetTexture();
				
			}else if(r == 3){
				Debug.Log ("Get a Color Gun");
				//Get a Color Gun 
				
			}else if(g == 3){
				Debug.Log ("Get a Color Shield");
				//Get a Color shield
				
			}else if(b == 3){
				Debug.Log ("Get a Magnet");
				//Get a Magnet
			}
		}

		CORE.GetComponent<P1_Core>().R = 0;
		CORE.GetComponent<P1_Core>().G = 0;
		CORE.GetComponent<P1_Core>().B = 0;
	}
}
