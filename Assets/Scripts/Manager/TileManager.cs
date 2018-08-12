using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileManager : MonoBehaviour {

	MapTile mt;

	public MapTile MT{
		get {
			return mt;
		}
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void setMT (MapTile t) {
		mt = t;
	}

}
