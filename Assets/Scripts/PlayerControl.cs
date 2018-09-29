using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour {

    public float speed;
    public float rotSpeed;


    private Rigidbody2D rb2D;

    void Awake()
    {
        rb2D = GetComponent<Rigidbody2D>();
    }

    void Start()
    {
        
    }

    void FixedUpdate()
    {
        bool fire = Input.GetButton("Jump");
        bool clockwise = Input.GetKey("l");
        bool antiClockwise = Input.GetKey("j");

        if (clockwise)
        {
            transform.Rotate(new Vector3(0.0f, 0.0f, -1.0f) * rotSpeed);
        }

        if (antiClockwise)
        {
            transform.Rotate(new Vector3(0.0f, 0.0f, 1.0f) * rotSpeed);
        }

        if (fire)
        {       
            rb2D.AddForce(transform.right * -speed);
        }
        
    }

}
