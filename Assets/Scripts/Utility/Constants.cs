using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Constants {

	static float sidePixels = 360;
	static float importPPU = 270;
	public static float sideLength = sidePixels / importPPU;

	public static int numPhases = 6; //Or by shape?

	public static int mapRadius = 4;

	public static float[,] deltas = new float[,] {{1, 0, -1}, {0, 1, -1}, {-1, 1, 0}, {-1, 0, 1}, {0, -1, 1}, {1, -1, 0}};

	public enum Colors{
		Red,
		Orange,
		Yellow,
		Green,
		Blue,
		Violet
	}

	public static float turnTime = 3f;

	//Shape Color orders
	public static Colors[] shape1 = new Colors[6] {Colors.Red, Colors.Orange, Colors.Yellow, Colors.Green, Colors.Blue, Colors.Violet};
	public static Colors[] shape2 = new Colors[6] {Colors.Orange, Colors.Green, Colors.Violet, Colors.Red, Colors.Yellow, Colors.Blue};
	public static Colors[] shape3 = new Colors[6] {Colors.Yellow, Colors.Blue, Colors.Green, Colors.Orange, Colors.Violet, Colors.Red};
	public static Colors[] shape4 = new Colors[6] {Colors.Green, Colors.Yellow, Colors.Blue, Colors.Violet, Colors.Red, Colors.Orange};
	public static Colors[] shape5 = new Colors[6] {Colors.Blue, Colors.Violet, Colors.Red, Colors.Yellow, Colors.Orange, Colors.Green};
	public static Colors[] shape6 = new Colors[6] {Colors.Violet, Colors.Red, Colors.Orange, Colors.Blue, Colors.Green, Colors.Yellow};



}
