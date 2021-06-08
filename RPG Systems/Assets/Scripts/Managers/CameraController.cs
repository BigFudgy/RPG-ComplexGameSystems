using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
	public Transform target;
	public Vector3 offset;

	public float pitch = 2f;

	private float zoomSpeed = 5f;
	public float maxZoom = 3f;
	public float minZoom = .3f;

	public float yawSpeed = 10f;
	
	private float currentZoom = 10f;
	private float currentYaw = 0.0f;
	private float yawInput = 0f;

	public Quaternion newRotation;


	 public void Update()
    {
		currentZoom -= Input.GetAxis("Mouse ScrollWheel") * zoomSpeed;
		currentZoom = Mathf.Clamp(currentZoom, minZoom, maxZoom);

		//float horiRotate = Input.GetAxis("HoriRotate");
		 
		//if (Input.GetKey(KeyCode.Q))
		//{
		//	transform.rotation *= Quaternion.Euler(Vector3.up * -yawSpeed);
		//
		//}
		//else if (Input.GetKey(KeyCode.E))
		//{
		//	transform.rotation *= Quaternion.Euler(Vector3.up * yawSpeed);
		//
		//}

	}


    public void LateUpdate()
    {
		transform.position = target.position - offset * currentZoom;
		transform.LookAt(target.position + Vector3.up * pitch);

		if (Input.GetKey(KeyCode.Q))
		{
			transform.rotation *= Quaternion.Euler(Vector3.up * -yawSpeed);
		
		}
		else if (Input.GetKey(KeyCode.E))
		{
			transform.rotation *= Quaternion.Euler(Vector3.up * yawSpeed);
		
		}
		//currentYaw -= Input.GetAxisRaw("Horizontal") * yawSpeed * Time.deltaTime;
		//transform.RotateAround(target.position, Vector3.up, currentYaw);
	}
}
