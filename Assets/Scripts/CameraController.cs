using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {
	Transform player;
	public float speed;
	// Use this for initialization
	void Start () {
		player = GameObject.FindGameObjectWithTag ("Player").transform;
	}
	// Update is called once per frame
	void LateUpdate () {
		Vector3 newPosition = new Vector3 (player.position.x, 
			player.position.y,
			transform.position.z);

		transform.position = Vector3.Lerp (transform.position, newPosition, Time.fixedDeltaTime * speed);
	}
}
