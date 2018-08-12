using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Colors = Constants.Colors;

public class Shape {

	int currentPhase = 1;

	int id = -1;

	public int ID{
		get {
			return id;
		}
	}

	public int CurrentPhase {
		get {
			return currentPhase;
		}
	}

	Colors[] colorOrder;
//
//	int[][][] shapeOffsets; //{set of all sets of offsets for a phase{set of all offsets for a phase  {individual offset for each tile}  }  }
//
	public Colors CurColor {
		get {
			return colorOrder [currentPhase-1];
		}
	}
//
//	public int[][] curOFfset {
//		get {
//			return shapeOffsets [currentPhase];
//		}
//	}

	public void AdvancePhase(){
		currentPhase++;
	}

	public void Reset(){
		currentPhase = 1;
	}

	public Shape(Colors[] colors, int id){
		colorOrder = colors;
		this.id = id;
	}
}
