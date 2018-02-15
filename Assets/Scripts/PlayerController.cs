using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	Rigidbody2D rb;
	public float speed;

    Animator animationController;
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D> ();
        animationController = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		float horizontal_movement = Input.GetAxis ("Horizontal");
		float vertical_movement = Input.GetAxis ("Vertical");

        animationController.SetFloat("movement", Mathf.Abs(horizontal_movement));  
		Vector2 force = new Vector2 (horizontal_movement, vertical_movement) * speed;
		rb.AddForce (force);
	}
}

