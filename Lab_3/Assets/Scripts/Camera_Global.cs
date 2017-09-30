using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Global : MonoBehaviour {

	public int cameraMode;

	public Transform player;

	public Rigidbody2D arby;

	public Transform BG2;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		switch (cameraMode) {

		default:
		case 1:
			this.transform.position = new Vector3 (player.position.x, 0, -10);
			break;
		case 2:
			this.transform.position = new Vector3 (BG2.position.x, BG2.position.y, -10);
			break;
		case 3:
			this.transform.position = new Vector3 (player.position.x, 0, -10);
			if(arby.velocity.x < 0)
			{
				this.GetComponent<Camera> ().orthographicSize += 0.005f;
			} else if (arby.velocity.x > 0)
			{
				if (this.GetComponent<Camera> ().orthographicSize > 1.7) {
					this.GetComponent<Camera> ().orthographicSize -= 0.005f;
				} 
			} 
            break;

		}
	}
}
