using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour {

    public int BMaxLife = 1;
    private int BLife;
    private BlocksHandler Bh;

	// Use this for initialization
	void Start () {
        BLife = BMaxLife;
        Bh = GetComponentInParent<BlocksHandler>();
	}
	
	// Update is called once per frame
	void Update () {
        if (BLife <= 0)
        {
            Destroy(gameObject);
            print("DEstroy");
        }
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Bullet")
        {
            BLife--;
            print("collide");
        }
    }
    /*
    void OnCollisionEnter(Collision collision)
    {
        print(collision.gameObject.tag);
        if (collision.collider.tag == "Bullet")
        {
            BLife--;
            print("collide");
        }
       
    }
    */
}
