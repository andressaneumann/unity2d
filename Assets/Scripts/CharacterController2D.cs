using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController2D : MonoBehaviour {

	private const float SkinWidth = .02f;
	private const int TotalHorizontalRays = 8;
	private const int TotalVerticalRays = 4;

	private static readonly float SlopeLimitTangant = Mathf.Tan (75f * Mathf.Deg2Rad);

	public LayerMask PlatformMask;
	public ControllerParameters2D DefaltParameters;

	public ControllerState2D State{ get; private set;}

	public void Awake(){

	}

	public void AddForce(Vector2 force){

	}

	public void SetForce(Vector2 force){
	
	
	}

	public void SetHorizontalForce(float x){
	
	}

	public void SetVerticalForce(float y){
		
	}

	public void Jump(){
	
	}

	public void LateUpdate(){
	
	}

	private void Move(Vector2 deltaMovement){
		
	}

	private void HandlePlatform(){
		
	}

	private void CalculateRayOrigins(){
		
	}

	private void MoveHorizontally(ref Vector2 deltaMoviment){
	
	}

	private void MoveVertically(ref Vector2 deltaMoviment){
		
	}

	private void HandleVerticalSlope(ref Vector2 deltaMoviment){
	
	}

	private void HandleHorizontalSlope(ref Vector2 deltaMoviment, float angle, bool isGoingRight){
	
	}

	public void OnTriggerEnter2D(Collider2D other){
	
	}
}
