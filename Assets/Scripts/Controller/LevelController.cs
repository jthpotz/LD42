using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelController : MonoBehaviour {

	ShapeController sc;
	CollisionController cc;

	int score = 0;

	GameObject[] queues = new GameObject[4];

	GameObject[] cols = new GameObject[4];

	public int Score{
		get {
			return score;
		}
	}

	int nextNum = 0;

	int numCol = 0;

	// Use this for initialization
	void Start () {
		sc = GameObject.FindGameObjectWithTag ("ShapeController").GetComponent<ShapeController> ();
		cc = GameObject.FindGameObjectWithTag ("CollisionController").GetComponent<CollisionController> ();
		queues [0] = GameObject.FindGameObjectWithTag ("Queue1");
		queues [1] = GameObject.FindGameObjectWithTag ("Queue2");
		queues [1].SetActive (false);
		queues [2] = GameObject.FindGameObjectWithTag ("Queue3");
		queues [2].SetActive (false);
		queues [3] = GameObject.FindGameObjectWithTag ("Queue4");
		queues [3].SetActive (false);

		cols [0] = GameObject.FindGameObjectWithTag ("Col1");
		cols [1] = GameObject.FindGameObjectWithTag ("Col2");
		cols [2] = GameObject.FindGameObjectWithTag ("Col3");
		cols [3] = GameObject.FindGameObjectWithTag ("Col4");

	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void NextTurn(){
		sc.Advance ();
		Spawn ();
		if(cc.CheckCollision ()){
			switch(numCol){
				case 0:
					cols [0].SetActive (false);
					break;
				case 1:
					cols [1].SetActive (false);
					break;
				case 2:
					cols [2].SetActive (false);
					break;
				case 3:
					cols [3].SetActive (false);
					break;
				case 4:
					GameOver ();
					break;
			}
			numCol++;
		}
	}

	public void Spawn(){
		nextNum = Randomization.RandomPercentage ();
//		Debug.Log ("num: " + nextNum);
//		Debug.Log ("score: " + score);
		if (score == 0){
			sc.AddShape (SelectPrefab.RandomShape (), 1);
		}
		if (score == 10){
			if (nextNum < 20){
				sc.AddShape (SelectPrefab.RandomShape (), 1);
			}
		}
		if(score > 100){
			if (nextNum < 30){
				sc.AddShape (SelectPrefab.RandomShape (), 1);
			}
		}
		if(score > 250){
			if (nextNum < 40){
				sc.AddShape (SelectPrefab.RandomShape (), 1);
			}
		}
		if(score > 300 && queues[1].activeSelf == false){
			queues [1].SetActive (true);
		}
		if(score > 300){
			if (nextNum < 25){
				sc.AddShape (SelectPrefab.RandomShape (), 1);
			}
			if (nextNum < 25){
				sc.AddShape (SelectPrefab.RandomShape (), 2);
			}
		}
		if(sc.ShapesQueued.Count == 0){
			sc.AddShape (SelectPrefab.RandomShape (), 1);
		}
	}

	public void AddToScore(int num){
		score += num;
	}

	public void GameOver(){
		SceneManager.LoadScene ("MainMenu");
	}

}
