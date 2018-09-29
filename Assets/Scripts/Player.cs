using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
	private bool alive = true;
	public bool Alive {get{return alive;}}
	private int score = 0;
	public int Score {get{return score;}}
	public void Kill(){
		alive = false;
	}
	public void HitEnemy(){
		score++;
	}
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
