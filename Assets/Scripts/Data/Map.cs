using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Map {

	List<MapTile> tiles = new List<MapTile> ();

	public List<MapTile> Tiles{
		get {
			return tiles;
		}
	}

	public Map(Vector3 center = new Vector3(), int radius = 4){

		tiles.Add (new MapTile(center.x, center.y, center.z));

		for (int i = 0; i < radius; i++) {
			float r = center.x;
			float g = center.y - i;
			float b = center.z + i;

			for (int j = 0; j < 6; j++){
				for (int k = 0; k < i; k++){
					r = r + Constants.deltas [j, 0];
					g = g + Constants.deltas [j, 1];
					b = b + Constants.deltas [j, 2];
					tiles.Add (new MapTile(r, g, b));
				}

			}

		}

	}

	public void MapRing(Vector3 center = new Vector3(), int radius = 5){
		for (int i = radius-1; i < radius; i++) {
			float r = center.x;
			float g = center.y - i;
			float b = center.z + i;

			for (int j = 0; j < 6; j++){
				for (int k = 0; k < i; k++){
					r = r + Constants.deltas [j, 0];
					g = g + Constants.deltas [j, 1];
					b = b + Constants.deltas [j, 2];
					tiles.Add (new MapTile(r, g, b));
				}

			}

		}
	}

}
