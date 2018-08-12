using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Randomization : MonoBehaviour {

	private static System.Random r = new System.Random();

	//Min is inclusive, Max is exclusive
	public static int RandomInt (int min, int max){
		return r.Next (min, max);
	}

	public static int RandomPercentage (){
		return r.Next (0, 100);
	}

	public static int RandomPercentageCentered(){
		int temp = r.Next (0, 5);
		if (temp == 1){
			return r.Next (0, 30);
		}
		if (temp == 4){
			return r.Next (70, 100);
		}
		return r.Next (30, 70);
	}

}
