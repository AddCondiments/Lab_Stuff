using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BG_triggers : MonoBehaviour {

	public Camera_Global camera_controller;

	public int camera_mode;

	void OnTriggerEnter2D(Collider2D other) {
		camera_controller.cameraMode = camera_mode;
	}
}
