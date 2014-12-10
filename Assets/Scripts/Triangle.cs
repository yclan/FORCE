using UnityEngine;
using System.Collections;


public class Triangle : MonoBehaviour {

	public GameObject CORE;

	public GameObject CORE_1;
	public GameObject CORE_2;
	public GameObject CORE_3;

	public GameObject CameraShake;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		//Debug.Log (Core_Order);
	
	}

	void OnCollisionEnter(Collision collider){

		//Debug.Log (collider.gameObject.renderer.material.color);
		//Debug.Log (this.transform.parent.Find ("Mesh").gameObject.renderer.material.color);


		//When in different colors
		if(this.transform.parent.Find ("Mesh").gameObject.renderer.material.color != collider.gameObject.renderer.material.color){
			//Toggle off slef
			this.transform.parent.gameObject.SetActive(false);

			//Camera shake
			CameraShake.gameObject.SetActive(true);
	
		}else{

			//When in the same color

			//The outter core
			if(CORE.GetComponent<P1_Core>().Core_Order == 3){

				//Debug.Log (collider.gameObject.renderer.material.name);

				if(collider.gameObject.renderer.material.color == Color.red){
					CORE_3.renderer.material.color = Color.red;
					CORE.GetComponent<P1_Core>().R += 1;
					Debug.Log ("R = " + CORE.GetComponent<P1_Core>().R);
				}
				if(collider.gameObject.renderer.material.color == Color.green){
					CORE_3.renderer.material.color = Color.green;
					CORE.GetComponent<P1_Core>().G += 1;
					Debug.Log ("G = " + CORE.GetComponent<P1_Core>().G);
				}
				if(collider.gameObject.renderer.material.color == Color.blue){
					CORE_3.renderer.material.color = Color.blue;
					CORE.GetComponent<P1_Core>().B += 1;
					Debug.Log ("B = " + CORE.GetComponent<P1_Core>().B);
				}
				
			}

			if(CORE.GetComponent<P1_Core>().Core_Order == 2){
				
				if(collider.gameObject.renderer.material.color == Color.red){
					CORE_2.renderer.material.color = Color.red;
					CORE.GetComponent<P1_Core>().R += 1;
					Debug.Log ("R = " + CORE.GetComponent<P1_Core>().R);
				}
				if(collider.gameObject.renderer.material.color == Color.green){
					CORE_2.renderer.material.color = Color.green;
					CORE.GetComponent<P1_Core>().G += 1;
					Debug.Log ("G = " + CORE.GetComponent<P1_Core>().G);
				}
				if(collider.gameObject.renderer.material.color == Color.blue){
					CORE_2.renderer.material.color = Color.blue;
					CORE.GetComponent<P1_Core>().B += 1;
					Debug.Log ("B = " + CORE.GetComponent<P1_Core>().B);
				}
				
			}

			if(CORE.GetComponent<P1_Core>().Core_Order == 1){
	
				if(collider.gameObject.renderer.material.color == Color.red){
					CORE_1.renderer.material.color = Color.red;
					CORE.GetComponent<P1_Core>().R += 1;
					Debug.Log ("R = " + CORE.GetComponent<P1_Core>().R);
				}
				if(collider.gameObject.renderer.material.color == Color.green){
					CORE_1.renderer.material.color = Color.green;
					CORE.GetComponent<P1_Core>().G += 1;
					Debug.Log ("G = " + CORE.GetComponent<P1_Core>().G);
				}
				if(collider.gameObject.renderer.material.color == Color.blue){
					CORE_1.renderer.material.color = Color.blue;
					CORE.GetComponent<P1_Core>().B += 1;
					Debug.Log ("B = " + CORE.GetComponent<P1_Core>().B);
				}

				//Send R, G, B to powerUP() function
				powerUP(CORE.GetComponent<P1_Core>().R, CORE.GetComponent<P1_Core>().G, CORE.GetComponent<P1_Core>().B);
				
			}

			CORE.GetComponent<P1_Core>().Core_Order -= 1;
		}

	}
	

	public void powerUP(int r, int g, int b){

		CORE_1.renderer.material.color = Color.white;
		CORE_2.renderer.material.color = Color.white;
		CORE_3.renderer.material.color = Color.white;

		CORE.GetComponent<P1_Core>().Core_Order = 4;
		
		if(r == 3 || g == 3 || b == 3){
			//Get a Power-Up
			CORE.transform.Find ("PowerUp").gameObject.SetActive(false);
			CORE.transform.Find ("Random").gameObject.SetActive(true);

			CORE.GetComponent<P1_Core>().R = 0;
			CORE.GetComponent<P1_Core>().G = 0;
			CORE.GetComponent<P1_Core>().B = 0;

			Debug.Log ("Get a Power-Up");
			
		}

		if(r == 1 && g == 1 && b == 1){
			//Get a Weapon
			CORE.transform.Find ("Weapon").gameObject.SetActive(false);
			CORE.transform.Find ("Random").gameObject.SetActive(true);

			CORE.GetComponent<P1_Core>().R = 0;
			CORE.GetComponent<P1_Core>().G = 0;
			CORE.GetComponent<P1_Core>().B = 0;

			Debug.Log ("Get a Weapon");
		}
	}
}
