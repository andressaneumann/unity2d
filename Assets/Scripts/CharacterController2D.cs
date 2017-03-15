using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {

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



}
