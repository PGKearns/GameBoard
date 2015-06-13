using UnityEngine;
using System.Collections;

public class TileTestboard : MonoBehaviour {
	public GameObject brick;
	// Use this for initialization
	void Start () {
	
		float offsetx = 0;
		float offsety = 0;
		for (int y = -5; y < 5; y++) {
			for (int x = -10; x < 10; x++) {
				//Instantiate(brick, new Vector3(x+offsetx, y+offsety, 0), Quaternion.identity);
				GameObject tile = Instantiate(brick, new Vector3(x+offsetx, y+offsety, 0), Quaternion.identity) as GameObject; 
				tile.transform.parent = GameObject.Find("boardHolder").transform;
				offsetx=offsetx+0.1f;
			}
			offsety=offsety+0.1f;
			offsetx=0;
		}

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
