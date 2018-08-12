using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour {

	RaycastHit2D hit;

	Vector2 mousePos;
	Vector2 lastPos;

	bool over = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		if(Input.GetMouseButtonDown (0)){
			lastPos = mousePos;
		}

		mousePos = Camera.main.ScreenToWorldPoint (new Vector2 (Input.mousePosition.x, Input.mousePosition.y));

		hit = Physics2D.Raycast (Camera.main.ScreenToWorldPoint (Input.mousePosition), Vector2.zero);
		if(hit.collider != null && hit.collider.transform.gameObject.tag == "Play"){
//			Debug.Log ("bla");
			over = true;
		}
//		Debug.Log (hit.collider);

		if(Input.GetMouseButtonUp (0) && over && lastPos == mousePos){
			SceneManager.LoadScene ("Game");
		}
	}
}
