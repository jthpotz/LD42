using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShapeManager : MonoBehaviour {

	Shape shape;

	Animator animator;

	GameObject[] positions = new GameObject[6];
	GameObject preview;

	bool[] pos = new bool[] {false, false, false, false, false, false, false};

	ShapeController sc;

	public ShapeController SC{
		get {
			return sc;
		}
		set {
			sc = value;
		}
	}

	public GameObject[] Positions{
		get {
			return positions;
		}
	}

	// Use this for initialization
	void Start () {
		animator = gameObject.GetComponent<Animator> ();


		foreach (Transform t in gameObject.GetComponentInChildren<Transform> ()){
			if(t.name == "Pos1"){
				positions [0] = t.gameObject;
			}
			if(t.name == "Pos2"){
				positions [1] = t.gameObject;
			}
			if(t.name == "Pos3"){
				positions [2] = t.gameObject;
			}if(t.name == "Pos4"){
				positions [3] = t.gameObject;
			}
			if(t.name == "Pos5"){
				positions [4] = t.gameObject;
			}
			if(t.name == "Pos6"){
				positions [5] = t.gameObject;
			}
			if(t.name == "Preview"){
				preview = t.gameObject;
			}

		}

	}
	
	// Update is called once per frame
	void Update () {
//		if(positions[0].activeSelf){
//			positions [0].SetActive (animator.GetBool ("Pos1"));
//			positions [1].SetActive (animator.GetBool ("Pos2"));
//		}
//		if(positions[1].activeSelf){
//			positions [1].SetActive (animator.GetBool ("Pos2"));
//			positions [2].SetActive (animator.GetBool ("Pos3"));
//		}
//		if(positions[2].activeSelf){
//			positions [2].SetActive (animator.GetBool ("Pos3"));
//			positions [3].SetActive (animator.GetBool ("Pos4"));
//		}
//		if(positions[3].activeSelf){
//			positions [3].SetActive (animator.GetBool ("Pos4"));
//			positions [4].SetActive (animator.GetBool ("Pos5"));
//		}
//		if(positions[4].activeSelf){
//			positions [4].SetActive (animator.GetBool ("Pos5"));
//			positions [5].SetActive (animator.GetBool ("Pos6"));
//		}
//		if(positions[5].activeSelf){
//			
//		}

		if (pos[0] || animator.GetBool ("Pos1")){
			preview.GetComponentInChildren<Transform> ().gameObject.SetActive (false);
			foreach (Transform t in positions[0].GetComponentInChildren<Transform> ()){
				t.gameObject.SetActive (true);
			}
			pos [0] = false;
//			animator.SetBool ("Pos1", false);
		}

		if (pos[1] || animator.GetBool ("Pos2")){
			foreach (Transform t in positions[0].GetComponentInChildren<Transform> ()){
				t.gameObject.SetActive (false);
			}
			foreach (Transform t in positions[1].GetComponentInChildren<Transform> ()){
				t.gameObject.SetActive (true);
			}
			pos [1] = false;
//			animator.SetBool ("Pos2", false);
		}

		if (pos[2] || animator.GetBool ("Pos3")){
			foreach (Transform t in positions[1].GetComponentInChildren<Transform> ()){
				t.gameObject.SetActive (false);
			}
			foreach (Transform t in positions[2].GetComponentInChildren<Transform> ()){
				t.gameObject.SetActive (true);
			}
			pos [2] = false;
//			animator.SetBool ("Pos3", false);
		}

		if (pos[3] || animator.GetBool ("Pos4")){
			foreach (Transform t in positions[2].GetComponentInChildren<Transform> ()){
				t.gameObject.SetActive (false);
			}
			foreach (Transform t in positions[3].GetComponentInChildren<Transform> ()){
				t.gameObject.SetActive (true);
			}
			pos [3] = false;
//			animator.SetBool ("Pos4", false);
		}

		if (pos[4] || animator.GetBool ("Pos5")){
			foreach (Transform t in positions[3].GetComponentInChildren<Transform> ()){
				t.gameObject.SetActive (false);
			}
			foreach (Transform t in positions[4].GetComponentInChildren<Transform> ()){
				t.gameObject.SetActive (true);
			}
			pos [4] = false;
//			animator.SetBool ("Pos5", false);
		}

		if (pos[5] || animator.GetBool ("Pos6")){
			foreach (Transform t in positions[4].GetComponentInChildren<Transform> ()){
				t.gameObject.SetActive (false);
			}
			foreach (Transform t in positions[5].GetComponentInChildren<Transform> ()){
				t.gameObject.SetActive (true);
			}
			pos [5] = false;
//			animator.SetBool ("Pos6", false);
		}

		if (pos[6] || animator.GetBool ("Done")){
			sc.ShapeDone (this);
			GameObject.Destroy (gameObject);
		}
	}

	public void SetShape(Shape s){
		shape = s;
	}

	public Shape GetShape(){
		return shape;
	}

	public void AdvancePosition(){
//		switch(shape.CurrentPhase){
//			case 1:
////				animator.SetTrigger ("1");
//				break;
//			case 2:
////				animator.SetTrigger ("2");
//				break;
//			case 3:
////				animator.SetTrigger ("3");
//				break;
//			case 4:
////				animator.SetTrigger ("4");
//				break;
//			case 5:
////				animator.SetTrigger ("5");
//				break;
//			case 6:
////				animator.SetTrigger ("6");
//				break;
//		}
		pos[shape.CurrentPhase] = true;
		shape.AdvancePhase ();
	}

	public void Begin(){
		pos [0] = true;
	}
}
