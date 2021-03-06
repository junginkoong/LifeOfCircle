﻿using System.Collections;
using UnityEngine;

public class OpenDoor1 : MonoBehaviour {

	public float speed = 0.1f;
	private bool platupdate = false;
	public GameObject platform;


	void Update(){
		if (platupdate && platform.transform.position.z > 9.5) {

			platform.transform.Translate (new Vector3 (0, 0, -speed));
		} 
		else if (!platupdate && platform.transform.position.z < 12.6){
			platform.transform.Translate (new Vector3 (0, 0, speed));
		}

	}

	void OnCollisionStay (Collision collision){
		platupdate = true;
	}
	void OnCollisionExit (Collision collision){
		platupdate = false;
	}
}
