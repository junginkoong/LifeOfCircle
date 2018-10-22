using System.Collections;
using UnityEngine;

public class CharacterControl : MonoBehaviour {


	public float speed =10.0f;
	public float jumpForce = 8.0f;
	public float distToGround = 0.5f;
	public bool jumped = false;
	private Rigidbody rg;

	// Use this for initialization
	void Start () {
		Cursor.lockState = CursorLockMode.Locked;
		rg = GetComponent<Rigidbody> ();
	}

	// Update is called once per frame\
	void Update(){
		if (Input.GetKeyDown("escape")){
			Cursor.lockState = CursorLockMode.None;
		}

		if (Input.GetKeyDown (KeyCode.Space)) {
			jumped = true;
		}

	}
	void FixedUpdate () {
		
		float translation = Input.GetAxis ("Vertical") * speed;
		float straffe = Input.GetAxis ("Horizontal") * speed;
		translation *= Time.deltaTime;
		straffe *= Time.deltaTime;

		transform.Translate (straffe, 0, translation);
		if (jumped && isGrounded()) {

			jumped = false;
			rg.AddForce (0, jumpForce, 0, ForceMode.Impulse);
		
		}


	}

	bool isGrounded (){
		return Physics.Raycast (transform.position, Vector3.down, distToGround);
	}
}
