using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour {
	public int maxLife;
	int life;
	bool attached;
	// Use this for initialization
	void Start () {
		life = maxLife;
		attached = false;
	}

	public int Life{
		get{
			return life;
		}
	}

	public bool Attached {
		get{
			return attached;
		}
		set{
			attached = value;
		}
	}
	// Update is called once per frame
	void Update () {
		
	}
}
