using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class MapMakerInputs : MonoBehaviour {
	private bool mouseHit;
	private RaycastHit hitInfo = new RaycastHit ();
	// Use this for initialization
	void Start () {
	
	}
	
	//this is code that tries to find and move the room that is right clicked on.  
	//not sure if it works at all.

	//it doesnt, problem is that it checks if the the button has been pressed, not held

	//rooms now move, not sure if it can be done cleaner...
	//what happens is GetMouseButtonDown runs the frame a button is pressed
	//GetMouseButton runs as long as the button is held
	void Update () {

		if (Input.GetMouseButtonDown (1)) {
			//Transform.gameObject.transform.localScale(new Vector3(2,2,2);
			bool hit = Physics.Raycast (Camera.main.ScreenPointToRay (Input.mousePosition), out hitInfo);
			if (hit)
				mouseHit = true;
		}



		if (Input.GetMouseButton (1)) {
			if (mouseHit) {
				Vector3 movement = hitInfo.transform.parent.transform.parent.transform.position;
				movement.x += Input.GetAxis ("Mouse X");
				movement.y += Input.GetAxis ("Mouse Y");
				hitInfo.transform.parent.transform.parent.transform.position = movement;
			}
		} else {
			mouseHit = false;
		}
		}



}