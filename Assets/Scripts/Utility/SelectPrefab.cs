using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Colors = Constants.Colors;

public class SelectPrefab {


	public static Object SolidHex(Colors color){
		switch(color){
			case Colors.Red:
				return Resources.Load ("Prefabs/Red");
			case Colors.Orange:
				return Resources.Load ("Prefabs/Orange");
			case Colors.Yellow:
				return Resources.Load ("Prefabs/Yellow");
			case Colors.Green:
				return Resources.Load ("Prefabs/Green");
			case Colors.Blue:
				return Resources.Load ("Prefabs/Blue");
			case Colors.Violet:
				return Resources.Load ("Prefabs/Violet");
			default:
				return Resources.Load ("Prefabs/Blank");

		}
	}

	public static Object PreviewHex(Colors color){
		switch(color){
			case Colors.Red:
				return Resources.Load ("Prefabs/Shape1Preview");
			case Colors.Orange:
				return Resources.Load ("Prefabs/OrangePreview");
			case Colors.Yellow:
				return Resources.Load ("Prefabs/YellowPreview");
			case Colors.Green:
				return Resources.Load ("Prefabs/GreenPreview");
			case Colors.Blue:
				return Resources.Load ("Prefabs/BluePreview");
			case Colors.Violet:
				return Resources.Load ("Prefabs/VioletPreview");
			default:
				return Resources.Load ("Prefabs/Blank");

		}
	}

	public static Object RandomShape(){
		switch(Randomization.RandomInt (0, 6)){
			case 0:
				return Resources.Load ("Prefabs/Shape1");
			case 1:
				return Resources.Load ("Prefabs/Shape1");
			case 2:
				return Resources.Load ("Prefabs/Shape1");
			case 3:
				return Resources.Load ("Prefabs/Shape1");
			case 4:
				return Resources.Load ("Prefabs/Shape1");
			case 5:
				return Resources.Load ("Prefabs/Shape1");
			default:
				return null;
		}
	}

}
