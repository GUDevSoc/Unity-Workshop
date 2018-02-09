using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordController : MonoBehaviour {
	Rigidbody2D rb;
	public float speed = 3;
	public float damage = 20;
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		rb.velocity = -transform.right*speed;
	}
}
