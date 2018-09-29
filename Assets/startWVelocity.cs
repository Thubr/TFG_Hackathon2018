using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class startWVelocity : MonoBehaviour {

    public Rigidbody2D rb;
    public float v = 3f;

	// Use this for initialization
	void Start () {
        
        rb.velocity = transform.right*v;
	}
	
	// Update is called once per frame
	void Update () {
        rb.velocity = v * (rb.velocity.normalized);
    }
}
