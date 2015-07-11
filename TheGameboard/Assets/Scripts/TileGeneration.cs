using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TileGeneration : MonoBehaviour {
	//public float startx;
	//public float starty;
	public Camera cam;
	public Slider xsize;
	public Slider ysize;
	public Slider radius;
	public GameObject brick;
	private Button MyButton;

	//this is the code that is run everytime that "Create Room Is pressed
	public void ButtonClick () {
		float camx = Mathf.Round(cam.transform.position.x);
		float camy = Mathf.Round(cam.transform.position.y);

		//create the room object this will hold all of the tiles instatiated for the rest of the code
		GameObject Room = new GameObject("Room");
		Room.transform.parent = GameObject.Find("boardHolder").transform;
		//create tiles one at a time
		for (float y = camy; y < (ysize.value+camy); y++) {
			for (float x =  camx; x < (xsize.value+camx); x++) {
				//Instantiate(brick, new Vector3(x+offsetx, y+offsety, 0), Quaternion.identity);
				GameObject tile = Instantiate(brick, new Vector3(x, y, 0), Quaternion.identity) as GameObject; 
				tile.transform.parent = Room.transform;

			}


		}
		//update the start position of the next room
		//startx +=  xsize.value;
		//starty +=  ysize.value;
	}


	public void CircleButtonClick () {
		
		//create the room object this will hold all of the tiles instatiated for the rest of the code
		GameObject Room = new GameObject("Room");
		Room.transform.parent = GameObject.Find("boardHolder").transform;
		//create tiles one at a time
		for (float y = 0; y < (ysize.value); y++) {
			for (float x =  0; x < (xsize.value); x++) {
				//Instantiate(brick, new Vector3(x+offsetx, y+offsety, 0), Quaternion.identity);
				if ( x>(radius.value/2)){
					GameObject tile = Instantiate(brick, new Vector3(x, y, 0), Quaternion.identity) as GameObject; 
					tile.transform.parent = Room.transform;
				}
			}
			
			
		}
		//update the start position of the next room
		//startx +=  xsize.value;
		//starty +=  ysize.value;
	}

	// Update is called once per frame
	void Update () {
	//fuck update we dont need it.
	}
}
