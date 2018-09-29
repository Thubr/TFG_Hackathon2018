using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {
	public static GameManager instance = null;
	public Player player1;
	public Player player2;
	private bool gameEnd = false;
	private bool gameBegin = false;
	public int Winner {get; set;}
	public AudioClip menu;
	public AudioClip main;
	void Awake(){
		if(instance == null){
			instance = this;
		}else if(instance != this){
			Destroy(gameObject);
		}
		DontDestroyOnLoad(gameObject);
	}
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(gameBegin == true && gameEnd == false){
			if(player1.Alive == false && player2.Alive == true){
				gameEnd = true;
				this.Winner = 1;
				EndGame();
			}
			else if(player1.Alive == true && player2.Alive == false){
				gameEnd = true;
				this.Winner = 0;
				EndGame();
			} else if(player1.Alive == false && player2.Alive == false){
				gameEnd = true;
				this.Winner = -1;
				EndGame();
			}
		}
	}

	void EndGame (){}

	public void LoadScene (){
		SceneManager.LoadScene("Main");
		gameBegin = true;
		SoundManager.instance.PlayBGM(main);
		player1 = new Player();
		player2 = new Player();
	}
}
