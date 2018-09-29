using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class constV : MonoBehaviour {

    public Rigidbody2D rb;
    public float constantSpeed = 3f;
	// Use this for initialization
	void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {
        rb.velocity = constantSpeed * (rb.velocity.normalized);
    }
}
