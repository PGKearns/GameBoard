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

	public void ButtonClick () {
		float offsetx = 0;
		float offsety = 0;
		for (float y = starty; y < ysize.value; y++) {
			for (float x =  startx; x < xsize.value; x++) {
				//Instantiate(brick, new Vector3(x+offsetx, y+offsety, 0), Quaternion.identity);
				GameObject tile = Instantiate(brick, new Vector3(x+offsetx, y+offsety, 0), Quaternion.identity) as GameObject; 
				tile.transform.parent = GameObject.Find("boardHolder").transform;
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
