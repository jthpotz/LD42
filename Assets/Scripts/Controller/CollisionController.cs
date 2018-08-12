using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Colors = Constants.Colors;

public class CollisionController : MonoBehaviour {

	ShapeController sc;

	RaycastHit2D hit;

	// Use this for initialization
	void Start () {
		sc = GameObject.FindGameObjectWithTag ("ShapeController").GetComponent<ShapeController> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public bool CheckCollision(){
		foreach (ShapeManager sm in sc.ShapesOnMap){
//			Debug.Log (sm.GetShape ().CurrentPhase);
			if(sm.GetShape ().CurrentPhase < 6){
				foreach (Transform t in sm.Positions[sm.GetShape ().CurrentPhase].GetComponentInChildren<Transform> ()){
					hit = Physics2D.Raycast (t.position, Vector2.zero, Mathf.Infinity, ~LayerMask.GetMask ("Map")&GetLayerMask (sm.GetShape ().CurColor));
					if(hit.collider != null && t.parent.parent != hit.collider.gameObject.transform.parent.parent){
//						Debug.Log ("hit  " + hit.collider.gameObject);
//						Debug.Log ("shooter: " + t.parent.parent + "   hit: " + hit.collider.gameObject.transform.parent.parent);
						sc.ShapeDone (hit.collider.gameObject.transform.parent.GetComponentInParent<ShapeManager> (), false);
						GameObject.Destroy (hit.collider.gameObject.transform.parent.parent.gameObject);
						sc.ShapeDone (t.parent.GetComponentInParent<ShapeManager> (), false);
						GameObject.Destroy (t.parent.parent.gameObject);
						return true;
					}
				}
			}

		}
		return false;
	}

//	private int GetLayerMask(Colors col){
//		int map = LayerMask.GetMask ("Map");
//		switch(col){
//			case Colors.Red:
//				return ~(LayerMask.GetMask ("Red") | LayerMask.GetMask ("Map"));
//			case Colors.Orange:
//				return ~(LayerMask.GetMask ("Orange") | LayerMask.GetMask ("Map"));
//			case Colors.Yellow:
//				return ~(LayerMask.GetMask ("Yellow") | LayerMask.GetMask ("Map"));
//			case Colors.Green:
//				return ~(LayerMask.GetMask ("Green") | LayerMask.GetMask ("Map"));
//			case Colors.Blue:
//				return ~(LayerMask.GetMask ("Blue") | LayerMask.GetMask ("Map"));
//			case Colors.Violet:
//				return ~(LayerMask.GetMask ("Violet") | LayerMask.GetMask ("Map"));
//			default:
//				return -1;
//		}
//	}

	private int GetLayerMask(Colors col){
		int map = LayerMask.GetMask ("Map");
		switch(col){
			case Colors.Red:
				return ~(LayerMask.GetMask ("Red"));
			case Colors.Orange:
				return ~(LayerMask.GetMask ("Orange"));
			case Colors.Yellow:
				return ~(LayerMask.GetMask ("Yellow"));
			case Colors.Green:
				return ~(LayerMask.GetMask ("Green"));
			case Colors.Blue:
				return ~(LayerMask.GetMask ("Blue"));
			case Colors.Violet:
				return ~(LayerMask.GetMask ("Violet"));
			default:
				return -1;
		}
	}

}
