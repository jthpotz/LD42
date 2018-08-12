using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

using Colors = Constants.Colors;

public class ShapeController : MonoBehaviour {

	List<ShapeManager> shapesOnMap = new List<ShapeManager>();
	List<ShapeManager> shapesQueued = new List<ShapeManager> ();

	ShapeManager[] queue1 = new ShapeManager[7];
	ShapeManager[] queue2 = new ShapeManager[7];
	ShapeManager[] queue3 = new ShapeManager[7];
	ShapeManager[] queue4 = new ShapeManager[7];

	ShapeManager[][] allQueues = new ShapeManager[4][];

	LevelController lc;

	public List<ShapeManager> ShapesOnMap{
		get {
			return shapesOnMap;
		}
	}

	public List<ShapeManager> ShapesQueued{
		get {
			return shapesQueued;
		}
	}

	float time;

	// Use this for initialization
	void Start () {


		allQueues [0] = queue1;
		allQueues [1] = queue2;
		allQueues [2] = queue3;
		allQueues [3] = queue4;

		lc = GameObject.FindGameObjectWithTag ("LevelController").GetComponent<LevelController> ();

		GameObject go = GameObject.Instantiate (Resources.Load ("Prefabs/Shape1"), new Vector2 (13.25f, -6), Quaternion.identity) as GameObject;
		ShapeManager sm = go.GetComponent<ShapeManager> ();
		sm.SetShape (new Shape(Constants.shape1, 1));
		sm.SC = this;
		shapesQueued.Add (sm);
		allQueues [0] [0] = sm;
//		GameObject go1 = GameObject.Instantiate (Resources.Load ("Prefabs/Shape1"), new Vector2 (11.25f, -6), Quaternion.identity) as GameObject;
//		ShapeManager sm1 = go1.GetComponent<ShapeManager> ();
//		sm1.SetShape (new Shape(Constants.shape1, 1));
//		sm1.SC = this;
//		shapesQueued.Add (sm1);
	}
	
	// Update is called once per frame
	void Update () {
//		time += Time.deltaTime;
//		if(time >= Constants.turnTime){
//			Advance ();
//			time = 0;
//		}
	}

	public void Advance(){
		Vector2 pos;
		foreach(ShapeManager sm in shapesOnMap){
			sm.AdvancePosition ();
		}
		foreach (ShapeManager[] queue in allQueues){
			if(queue[1] != null && queue[1].gameObject.transform.position.x > 9){
				pos = queue [1].gameObject.transform.position;
				pos.y -= 2.25f;
				queue [1].gameObject.transform.position = pos;
				queue [0] = queue [1];
			}
			for(int i = 2; i < 7; i++){
				if(queue[i] == null){
					continue;
				}
				pos = queue [i].gameObject.transform.position;
				pos.y -= 2;
				queue [i].gameObject.transform.position = pos;
				queue[i-1] = queue[i];
				queue[i] = null;
			}
		}
	}

	public bool Enqueued(ShapeManager sm){
		if(sm == null){
			Debug.Log ("wha?");
		}
		bool part1 = shapesQueued.Contains (sm);
		bool part2 = false;

		foreach (ShapeManager[] queue in allQueues) {
			if (queue [0] == sm) {
				part2 = true;
				return part1 && part2;
			}
		}

		return part1 && part2;
	}

	public void PlaceShape(ShapeManager sm){
		if(sm == null){
			Debug.Log ("huh? shouldn't be null");
			return;
		}
		sm.Begin ();
		shapesQueued.Remove (sm);
		shapesOnMap.Add (sm);
		lc.AddToScore (10);
		foreach (ShapeManager[] queue in allQueues){
			if(queue[0] == sm){
				queue [0] = null;
				return;
			}
//			for(int i = 0; i < 7; i++){
//				if(queue[i] == sm){
//					queue [i] = null;
//					return;
//				}
//			}
		}
		Debug.Log ("uhhh");
	}

	public void ShapeDone(ShapeManager sm, bool succsess = true){
		shapesOnMap.Remove (sm);
		if(succsess){
			lc.AddToScore (20);
		}

//		Debug.Log ("boop");
	}

	public void AddShape(Object prefab, int queueNum){
		
		GameObject go = GameObject.Instantiate (prefab, StartPos (queueNum), Quaternion.identity) as GameObject;
		ShapeManager sm = go.GetComponent<ShapeManager> ();
		sm.SetShape (new Shape (Constants.shape1, 1));
//		switch(Randomization.RandomInt(0, 6)){
//			case 0:
//				sm.SetShape (new Shape (Constants.shape1, 1));
//				break;
//			case 1:
//				sm.SetShape (new Shape(Constants.shape2, 2));
//				break;
//			case 2:
//				sm.SetShape (new Shape(Constants.shape3, 3));
//				break;
//			case 3:
//				sm.SetShape (new Shape(Constants.shape4, 4));
//				break;
//			case 4:
//				sm.SetShape (new Shape(Constants.shape5, 5));
//				break;
//			case 5:
//				sm.SetShape (new Shape(Constants.shape6, 6));
//				break;
//		}
		sm.SC = this;
		shapesQueued.Add (sm);
		allQueues [queueNum - 1] [6] = sm;
	}

	public Vector2 StartPos(int queueNum){
		switch(queueNum){
			case 1:
				return new Vector2 (13.25f, 6.25f);
			case 2:
				return new Vector2 (11.25f, 6.25f);
			case 3:
				return new Vector2 (15.25f, 6.25f);
			case 4:
				return new Vector2 (9.25f, 6.25f);
			default:
				return new Vector2 ();
		}
	}

	public bool Ready(){
//		for(int i = 0; i < queue1.Length; i++){
//			Debug.Log (queue1[i] + "   " + i);
//		}
//		Debug.Log (queue1);
//		Debug.Log (queue2);
//		Debug.Log (queue3);
//		Debug.Log (queue4);
		return queue1 [0] == null && queue2 [0] == null && queue3 [0] == null && queue4 [0] == null;
	}

}
