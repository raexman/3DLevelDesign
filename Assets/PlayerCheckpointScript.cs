using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCheckpointScript : MonoBehaviour {

	public int id;
	public GameObject explosionFX;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.CompareTag ("Player")) {

			Instantiate (explosionFX, transform);
			Destroy (other.gameObject);
			Application.Quit ();
			Debug.Log ("Trigger");
		}
	}
}
