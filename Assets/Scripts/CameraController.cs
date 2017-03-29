﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class CameraController : MonoBehaviour {

	public Transform Player;
	public Vector2 Margin;
	public Vector2 Smoothing;

	public BoxCollider2D Bounds;
	private Camera camera;

	private Vector3	
		_min,
		_max;

	public bool IsFollowing{ get; set;}

	public void Start(){

		_min = Bounds.bounds.min;
		_max = Bounds.bounds.max;
		//camera = GetComponent<Camera> ();
	}

	public void Update(){

		var x = transform.position.x;
		var y = transform.position.y;

		if (IsFollowing) {
			if (Mathf.Abs (x - Player.position.x) > Margin.x) {
				x = Mathf.Lerp (x, Player.position.x, Smoothing.x * Time.deltaTime);
			}

			if (Mathf.Abs (y - Player.position.y) > Margin.y) {
				y = Mathf.Lerp (y, Player.position.y, Smoothing.y * Time.deltaTime);
			}
		}

		var cameraHalfWidth = camera.orthographicSize * ((float)Screen.width / Screen.height);

		x = Mathf.Clamp (x, _min.x + cameraHalfWidth, _max.x - cameraHalfWidth);
		y = Mathf.Clamp (y, _min.y + camera.orthographicSize, _max.y - cameraHalfWidth);

		transform.position = new Vector3 (x, y, transform.position.z);
	}


		
			
}


