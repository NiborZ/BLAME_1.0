using UnityEngine;  
using System.Collections;  

public class PlayerMovement : MonoBehaviour {  
	public float speed = 6.0F;  
	public float jumpSpeed = 8.0F;  
	public float gravity = 20.0F;  
	public float rotateSpeed = 5f;
	private Vector3 moveDirection = Vector3.zero;  
	private float x;
	private float y;

	void Start() {  

	}  
	void Update() {  
		CharacterController controller = GetComponent<CharacterController>();  
		if (controller.isGrounded) {  
			moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));  
			moveDirection = transform.TransformDirection(moveDirection);  
			moveDirection *= speed;  
			if (Input.GetButton("Jump"))  
				moveDirection.y = jumpSpeed;  
		}  
		moveDirection.y -= gravity * Time.deltaTime;  
		controller.Move(moveDirection * Time.deltaTime);  

		x = Input.GetAxis("Mouse X") * rotateSpeed;
		transform.Rotate (Vector3.up, x);
		//Quaternion targetRotation =   Quaternion.Euler(45, 45, 45);
		//transform.rotation = Quaternion.Slerp(transform.rotation,targetRotation,Time.deltaTime *3);

	}  

}  