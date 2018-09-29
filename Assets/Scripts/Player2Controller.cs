using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2Controller : MonoBehaviour {

    public float speed;
    public float rotSpeed;

    private Rigidbody2D rb2D;

    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        //Player movement controller   
        Vector3 movement = new Vector3(Input.GetAxis("Horizontal2"), Input.GetAxis("Vertical2"), 0.0f);

        rb2D.velocity = movement * speed;



        //Player rotation controller
        float rotate = Input.GetAxis("Rotation2");

        Vector3 rotation = new Vector3(0.0f, 0.0f, rotate);

        transform.Rotate(rotation * -rotSpeed);

    }
}