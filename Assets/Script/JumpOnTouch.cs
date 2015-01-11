using UnityEngine;
using System.Collections;

public class JumpOnTouch : MonoBehaviour {

	public float jumpPower = 4;
	private bool isFalling = true;
	
	void FixedUpdate(){
#if UNITY_EDITOR
		if (Input.GetKeyDown("space")  && !isFalling)
		{
			isFalling=true;
			rigidbody2D.velocity=new Vector2(rigidbody2D.velocity.x,jumpPower);
		}
#endif

		bool isTouch = false;
		for (int i = 0; i < Input.touchCount; i++)
			if (Input.GetTouch(i).phase == TouchPhase.Began)
				isTouch = true;

		if (isTouch && !isFalling)
		{
			isFalling=true;
			rigidbody2D.velocity=new Vector2(rigidbody2D.velocity.x,jumpPower);
		}
	}
	
	void OnCollisionEnter2D(Collision2D collisionInfo) {
		//we are on something
		if (collisionInfo.gameObject.tag == "rail")
			isFalling=false;
	}
	
	void OnCollisionExit2D(Collision2D collisionInfo) {
		//we are on something
		if (collisionInfo.gameObject.tag == "rail")
			isFalling=true;
	}
}
