using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Colors = Constants.Colors;

public class MouseController : MonoBehaviour {

	Vector2 mousePos;
	Vector2 lastPos;

	RaycastHit2D hit;
	Ray2D ray;

	bool dragging = false;

	GameObject selected;
	GameObject dragged;

	ShapeController sc;
	MapController mc;
	LevelController lc;

	// Use this for initialization
	void Start () {
		sc = GameObject.FindGameObjectWithTag ("ShapeController").GetComponent<ShapeController> ();
		mc = GameObject.FindGameObjectWithTag ("MapController").GetComponent<MapController> ();
		lc = GameObject.FindGameObjectWithTag ("LevelController").GetComponent<LevelController> ();
//		Debug.Log (sc + " " + mc);
	}
	
	// Update is called once per frame
	void Update () {

		if(Input.GetKeyUp (KeyCode.Space) && sc.Ready()){
			lc.NextTurn ();
		}

		if(dragging && Input.GetKeyUp (KeyCode.Q)){
			dragged.transform.Rotate (Vector3.forward, 60f);
			selected.transform.Rotate (Vector3.forward, 60f);
		}

		if(dragging && Input.GetKeyUp (KeyCode.E)){
			dragged.transform.Rotate (Vector3.forward, -60f);
			selected.transform.Rotate (Vector3.forward, -60f);
		}


		if(Input.GetMouseButtonDown (0)){
			lastPos = mousePos;
		}

		mousePos = Camera.main.ScreenToWorldPoint (new Vector2 (Input.mousePosition.x, Input.mousePosition.y));

//		Debug.Log ("last: " + lastPos + "cur: " + mousePos);

		if(Input.GetMouseButtonUp (0) && lastPos == mousePos && dragging){
//			Debug.Log (5);
			if(LayerMask.NameToLayer ("Map") == -1){
//				Debug.Log ("problem"); 
			}
			hit = Physics2D.Raycast (Camera.main.ScreenToWorldPoint (Input.mousePosition), Vector2.zero, Mathf.Infinity, LayerMask.GetMask ("Map"));
			if(hit.collider != null && mc.CheckMapTile (hit.collider.gameObject.GetComponent<TileManager> ())){
//				Debug.Log (6);
				sc.PlaceShape (selected.GetComponent<ShapeManager> ());
				selected.transform.position = hit.collider.transform.position;
				GameObject.Destroy (dragged);
				dragging = false;
				return;
			}
			else if(hit.collider != null){
//				Debug.Log (hit.collider.gameObject);
			}
		}

		if(Input.GetMouseButtonUp (0) && lastPos == mousePos && !dragging){

//			Debug.Log (1);

			hit = Physics2D.Raycast (Camera.main.ScreenToWorldPoint (Input.mousePosition), Vector2.zero);

			if(hit.collider != null){
				ShapeManager sm = hit.collider.gameObject.GetComponentInParent<Transform> ().GetComponentInParent<ShapeManager> ();
				if(sc.Enqueued (sm)){
//					Debug.Log (2);
					dragging = true;
					selected = sm.gameObject;
					dragged = GameObject.Instantiate (SelectPrefab.PreviewHex (GetColorFromShapeID (sm.GetShape ().ID)), new Vector3(), Quaternion.identity) as GameObject;
//					Debug.Log (selected);
			}
			}
		}

		if(dragging){
//			Debug.Log (3);
			hit = Physics2D.Raycast (Camera.main.ScreenToWorldPoint (Input.mousePosition), Vector2.zero);
			if(hit.collider != null){
				TileManager tm = hit.collider.gameObject.GetComponent<TileManager> ();
				if( mc.CheckMapTile (tm)){
//					Debug.Log (4);
					if(Mathf.Abs (tm.MT.R) < Constants.mapRadius-1 && Mathf.Abs (tm.MT.B) < Constants.mapRadius-1 && Mathf.Abs (tm.MT.G) < Constants.mapRadius-1){
						dragged.transform.position = hit.collider.transform.position;
					}

//					if (Input.GetMouseButtonUp (0) && lastPos == mousePos){
//						Debug.Log (5);
//						sc.PlaceShape (gameObject.GetComponent<ShapeManager> ());
//						dragging = false;
//					}
//					else{
//						if(Input.GetMouseButtonUp (0)){
//							Debug.Log ((lastPos == mousePos) + " " + lastPos + " " + mousePos);	
//						}
//					}

				}

			}
		
		}


	}

	private Colors GetColorFromShapeID(int id){
		switch(id){
			case 1:
				return Colors.Red;
			case 2:
				return Colors.Orange;
			case 3:
				return Colors.Yellow;
			case 4:
				return Colors.Green;
			case 5:
				return Colors.Blue;
			case 6:
				return Colors.Violet;
			default:
				return Colors.Red;
		}
	}

}
