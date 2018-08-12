using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class MapController : MonoBehaviour {

	Map map;

	List<TileManager> tileManagerList = new List<TileManager> ();

	public List<TileManager> TileManagerList{
		get {
			return tileManagerList;
		}
	}

	// Use this for initialization
	void Start () {
		map = new Map ();
		//map.MapRing (new Vector3 (), 7);
		DisplayMap ();

	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void DisplayMap (){
		GameObject go;
		foreach (MapTile mt in map.Tiles){
			//Debug.Log (mt.SquareCoord.ToString ());
			//Debug.Log ("x: " + mt.X + " y: " + mt.Y); 
			go = GameObject.Instantiate (Resources.Load ("Prefabs/Blank"), mt.SquareCoord, Quaternion.identity) as GameObject;
			TileManager tm = go.GetComponent<TileManager> ();
			tm.setMT (mt);
			tileManagerList.Add (tm);
			go.name = mt.CubeCoord.ToString ();
		}
	}

	public bool CheckMapTile(TileManager tm){
		return tileManagerList.Contains (tm);
	}
}
