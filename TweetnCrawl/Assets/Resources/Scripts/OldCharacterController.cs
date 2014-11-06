﻿using UnityEngine;
using System.Collections;

public class OldCharacterController : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}


    void Update()
    {
        transform.rotation = Quaternion.identity;
        rigidbody2D.velocity = new Vector2(0,0);
    }
	// Update is called once per frame
	void FixedUpdate () {
        transform.rotation = Quaternion.identity;
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(new Vector3(0, 0.32f));
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(new Vector3(0, -0.32f));
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(new Vector3(-0.32f, 0));
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(new Vector3(0.32f, 0));
        }
	}
}
