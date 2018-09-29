using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attached : MonoBehaviour {

    private Block block;
    private bool attached;
   

	// Use this for initialization
	void Start () {
        block = GetComponent<Block>();

	}
	
	// Update is called once per frame
	void Update () {
        if (attached == false && transform.parent != null) transform.parent = null;
	}

    void OnCollisionStay(Collision collision)
    {

        if(collision.gameObject.tag == "Block")
        {
            var adj = collision.gameObject;
            if (adj.GetComponent<Attached>().attached == false) attached = false;
            else attached = true;
           

        }
    }
}
