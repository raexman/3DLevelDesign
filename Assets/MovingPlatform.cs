using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour {

	Vector3 startPos;

	// Use this for initialization
	void Start () {
		startPos = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = new Vector3(startPos.x + Mathf.Sin (Time.time) * 5, transform.position.y, transform.position.z);
	}
}
