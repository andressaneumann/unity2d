using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	private bool _isFacingRight;
	private CharacterController2D _controller;
	private float _normalizedHorizontalSpeed;

	public float MaxSpeed;
	public float SpeedAccelerationOnGround = 10f;
	public float SppedAccelerationInAir = 5f;

	public void Start(){

		_controller = GetComponent<CharacterController2D> ();
		_isFacingRight = transform.localScale.x > 0;
		
	}

	public void Update(){
	
		HandleInput ();

		var movementFactor = _controller.State.IsGrounded ? SpeedAccelerationOnGround : SppedAccelerationInAir;
	}
}
