using System.Collections;
using UnityEngine;

public class OpenDoor : MonoBehaviour {

	public float speed = 0.1f;
	private bool platupdate = false;
	public GameObject platform;


	void Update(){
		if (platupdate && platform.transform.position.x > -10.5) {

			platform.transform.Translate (new Vector3 (-speed, 0, 0));
		} 
		else if (!platupdate && platform.transform.position.x < -8){
			platform.transform.Translate (new Vector3 (speed, 0, 0));
		}

	}

	void OnCollisionStay (Collision collision){
		platupdate = true;
	}
	void OnCollisionExit (Collision collision){
		platupdate = false;
	}
}
