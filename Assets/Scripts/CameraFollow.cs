using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {

	public ControllerState2D target;
	public Vector2 focusAreaSize;

	struct FocusArea{
		public Vector2 centre;
		public Vector2 velocity;
		float left, right;
		float top, bottom;

		public FocusArea(Bounds targetBounds, Vector2 size){
			left = targetBounds.center.x - size.x/2;
			right = targetBounds.center.x + size.x/2;
			bottom = targetBounds.min.y;
			top = targetBounds.min.y + size.y;
			velocity = Vector2.zero;

			centre = new Vector2((left+right)/2, (top + bottom)/2);
		}

		public void Update(Bounds targetBounds){
			float shiftX = 0;
			if (targetBounds.min.x < left) {
				shiftX = targetBounds.min.x - left;
			} else if (targetBounds.max.x > right) {
				shiftX = targetBounds.max.x - right;
			}

			left += shiftX;
			right += shiftX;

			float shiftY = 0;
			if (targetBounds.min.y < bottom) {
				shiftX = targetBounds.min.y - bottom;
			} else if (targetBounds.max.y > top) {
				shiftX = targetBounds.max.x - top;
			}

			top += shiftX;
			bottom += shiftX;
			centre = new Vector2((left+right)/2, (top + bottom)/2);
			velocity = new Vector2 (shiftX, shiftY);
		}

	}


}
