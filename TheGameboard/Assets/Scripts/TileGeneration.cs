using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TileGeneration : MonoBehaviour {
	public float startx;
	public float starty;
	public Slider xsize;
	public Slider ysize;
	public GameObject brick;
	private Button MyButton;

	//this is the code that is run everytime that "Create Room Is pressed
	public void ButtonClick () {

		//create the room object this will hold all of the tiles instatiated for the rest of the code
		GameObject Room = new GameObject("Room");
		Room.transform.parent = GameObject.Find("boardHolder").transform;
		//create tiles one at a time
		for (float y = starty; y < (ysize.value+starty); y++) {
			for (float x =  startx; x < (xsize.value+startx); x++) {
				//Instantiate(brick, new Vector3(x+offsetx, y+offsety, 0), Quaternion.identity);
				GameObject tile = Instantiate(brick, new Vector3(x, y, 0), Quaternion.identity) as GameObject; 
				tile.transform.parent = Room.transform;

			}


		}
		startx =  xsize.value;
		starty =  ysize.value;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
