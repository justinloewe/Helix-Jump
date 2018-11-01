using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {

	public GameObject Splash_Prefab;

	public float force;

	void OnCollisionEnter(Collision col){

		if (col.gameObject.tag == "h_piece") {
			gameObject.GetComponent<Rigidbody> ().AddForce (new Vector3 (0f, 1f, 0f) * Time.deltaTime * force);
			GameObject splash = Instantiate (Splash_Prefab);
			splash.transform.SetParent (GameObject.Find("helix").transform);
		}

	}
		
}

