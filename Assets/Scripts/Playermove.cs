using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playermove : MonoBehaviour {

    public float speed = 5;
    public float jumpHeight = 100;
    public GameObject respawnPoint;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        //GOing to set velocity
        float movement = Input.GetAxis("Horizontal") * speed;
        Rigidbody2D rb = GetComponent<Rigidbody2D>();
        //rb.velocity = new Vector3(movement, rb.velocity.y, 0);

       

        rb.velocity = new Vector3(movement, rb.velocity.y, 0);
        
	}

    void Update()
    {
        //float jump = Input.GetAxis("Jump");
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject feet = transform.GetChild(0).gameObject;
            Collider2D[] colliders = Physics2D.OverlapCircleAll(feet.transform.position, .3f);
            foreach (Collider2D col in colliders)
            {
                if (col.gameObject != this.gameObject)
                {
                    Rigidbody2D rb = GetComponent<Rigidbody2D>();
                    rb.velocity = new Vector2(rb.velocity.x, 0);
                    rb.AddForce(Vector2.up * jumpHeight);

                }

            }

        }

        if(transform.position.y <= -10)
        {
            transform.position = respawnPoint.transform.position;
        }
    }
}
