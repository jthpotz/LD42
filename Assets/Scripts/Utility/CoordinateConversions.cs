using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoordinateConversions {

	//Something is funky here, avoid if at all possible
	public static Vector3 SquareToCube (float x, float y){
		
		float r = (((float)Mathf.Sqrt (3f) / 3f) * x - (y / 3f)) / Constants.sideLength;
		float b = (((2f / 3f) * y) / Constants.sideLength);
		float g= (-((float)Mathf.Sqrt (3f) / 3f) * x + (y / 3f)) / Constants.sideLength;
//		Debug.Log ("wtf: " + (((2 / 3) * y) / Constants.sideLength));
//		Debug.Log ("x: " + x + " y:" + y + " r: " + r + " b: " + b + " g:" + g); 

		return new Vector3 (r, b, g);
	}

	public static Vector3 SquareToCube (Vector2 square){
		return SquareToCube (square.x, square.y);
	}

	public static Vector2 CubeToSquare (float r, float b, float g){
		float x = Mathf.Sqrt (3) * Constants.sideLength * ((b / 2) + r);
		float y = 1.5f * Constants.sideLength * b;

		return new Vector2 (x, y);
	}

	public static Vector2 CubeToSquare (Vector3 cube){
		return CubeToSquare (cube.x, cube.y, cube.z);
	}

}
