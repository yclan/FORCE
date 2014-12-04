using UnityEngine;
using System.Collections;

public class Triangle : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

	
	}


	void OnCollisionEnter(Collision collider){

		//Debug.Log (collider.gameObject.renderer.material);
		//Debug.Log (this.transform.parent.Find ("Mesh").gameObject.renderer.material);

		if(this.transform.parent.Find ("Mesh").gameObject.renderer.material.name != collider.gameObject.renderer.material.name){
			this.transform.parent.gameObject.SetActive(false);
		}

//		if(collider.GetComponent<MeshRenderer>().Material.name == ){
//
//		}

	}
}
