using UnityEngine;
using System.Collections;

public class cameraController : MonoBehaviour {
	public Camera mainCamera;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		mainCamera.orthographicSize += Input.GetAxis("Mouse ScrollWheel");

		if (Input.GetMouseButton (2)) {
			Vector3 movementcam = mainCamera.transform.position;
			movementcam.x += Input.GetAxis("Mouse X");
			movementcam.y += Input.GetAxis("Mouse Y");
			mainCamera.transform.position = movementcam;
		}
	}
}
