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
		float offsetx = 0;
		float offsety = 0;
		//create the room object this will hold all of the tiles instatiated for the rest of the code
		GameObject Room = new GameObject("Room");
		Room.transform.parent = GameObject.Find("boardHolder").transform;
		//create tiles one at a time
		for (float y = starty; y < ysize.value; y++) {
			for (float x =  startx; x < xsize.value; x++) {
				//Instantiate(brick, new Vector3(x+offsetx, y+offsety, 0), Quaternion.identity);
				GameObject tile = Instantiate(brick, new Vector3(x+offsetx, y+offsety, 0), Quaternion.identity) as GameObject; 
				tile.transform.parent = Room.transform;
				offsetx=offsetx+0.1f;
			}
			offsety=offsety+0.1f;
			offsetx=0;

		}
		startx =  xsize.value;
		starty =  ysize.value;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
