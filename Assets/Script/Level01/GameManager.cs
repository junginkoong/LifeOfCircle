using System.Collections;
using UnityEngine;

public class GameManager : MonoBehaviour {

	public GameObject completeUI;

	public void CompleteLevel(){

		completeUI.SetActive (true);
	}
}
