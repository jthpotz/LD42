using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapTile {

	float r = 0;
	float g = 0;
	float b = 0;

	public float R {
		get {
			return r;
		}
	}

	public float B {
		get {
			return b;
		}
	}

	public float G{
		get {
			return g;
		}
	}

	public Vector3 CubeCoord {
		get {
			return new Vector3 (r, g, b);
		}
	}

	public Vector2 SquareCoord {
		get {
			return new Vector2 (X, Y);
		}
	}

	public float X {
		get {
			return (Mathf.Sqrt (3) * Constants.sideLength * ((b / 2) + r));
		}
	}

	public float Y {
		get {
			return (float)(1.5 * Constants.sideLength * b);
		}
	}

	public MapTile(float r, float g, float b){
		this.r = r;
		this.g = g;
		this.b = b;
	}

}
