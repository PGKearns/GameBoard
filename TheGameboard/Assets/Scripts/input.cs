using UnityEngine;
using System.Collections;

public class input : MonoBehaviour {
	public Light vision;
	public Camera MainCam;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (0)) {
			ParticleSystem ps;
			//Transform.gameObject.transform.localScale(new Vector3(2,2,2);
			RaycastHit hitInfo = new RaycastHit();
			bool hit = Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hitInfo);
			if (hit) 
			{
				Debug.Log("Hit " + hitInfo.transform.gameObject.name);
				//hitInfo.transform.gameObject.Renderer

				ps = hitInfo.transform.gameObject.GetComponentInChildren<ParticleSystem>();
				if(ps.emissionRate==5){
					ps.emissionRate=0;
				}
				else{
					ps.emissionRate=5;
				}
			} else {
				Debug.Log("No hit");
			}
		
		}
	
	//THIS MOVES THE LIGHT THAT REPRESENTS PLAYERS VISION
		//STraight.
		if (Input.GetMouseButton (1)) {
			Vector3 movement = vision.transform.position;
			movement.x += Input.GetAxis("Mouse X");
			movement.y += Input.GetAxis("Mouse Y");
			vision.transform.position = movement;
		}



	}
}
