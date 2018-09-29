using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public float speed;
    public float rotSpeed;

    private Rigidbody2D rb2D;
    
    void Start()
    {
        rb2D =  GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        //Player movement controller   
        Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0.0f);      

        rb2D.velocity = movement * speed;



        //Player rotation controller
        float rotate = Input.GetAxis("Rotation");

        Vector3 rotation = new Vector3(0.0f, 0.0f, rotate);

        transform.Rotate(rotation * -rotSpeed);

    }

}
