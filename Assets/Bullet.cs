﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {

    GameObject player;
	// Use this for initialization
	void Start () {
        player = GameObject.FindGameObjectWithTag("Player");
	}
	
	// Update is called once per frame
	void Update () {
        GetComponent<Rigidbody2D>().velocity = transform.right * 10;
	}

    void OnCollisionEnter2D(Collision2D col)
    {
        //Just a test of color
        Globals.playerObject.GetComponent<SpriteRenderer>().color = Random.ColorHSV();
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        Destroy(gameObject);
    }
}
