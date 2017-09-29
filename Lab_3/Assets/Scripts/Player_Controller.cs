using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Controller : MonoBehaviour {

	public float speed = 2;

	private Rigidbody2D arby;

	// Use this for initialization
	void Start () {
		arby = this.GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {
		float hMove = Input.GetAxis ("Horizontal");
		arby.velocity = new Vector2 (hMove, 0) * speed;
	}
}
