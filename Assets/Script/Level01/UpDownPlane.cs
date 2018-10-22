using System.Collections;
using UnityEngine;

public class UpDownPlane : MonoBehaviour {

	public float position = 15f;
	
	// Update is called once per frame
	void Update () {
		
	}
	public void PlatformDown(){
		Debug.Log ("DOWNDWN");
	}
	public void PlatformUp(){
		Debug.Log ("UPUP");	
	}
}
