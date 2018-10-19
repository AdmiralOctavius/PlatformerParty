using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class Playermove : MonoBehaviour {

    public float speed = 5;
    public float walkSpeed = 5;
    public float jumpHeight = 100;
    public float sprintSpeed = 15;
    public GameObject respawnPoint;

    public GameObject laserPrefab;
	// Use this for initialization
	void Start () {
        Globals.playerObject = gameObject;		
	}

    public void SetRespawnPoint(GameObject vec)
    {
        respawnPoint = vec;
    }
	
	// Update is called once per frame
	void FixedUpdate () {
        Rigidbody2D rb = GetComponent<Rigidbody2D>();
        //rb.velocity = new Vector3(movement, rb.velocity.y, 0);
        Animator anim = GetComponent<Animator>();
        if (Input.GetKey(KeyCode.LeftShift))
        {
            speed = sprintSpeed;
        }
        else
        {
            speed = walkSpeed;
        }
        //GOing to set velocity
        float movement = Input.GetAxis("Horizontal") * speed;
        SpriteRenderer sr = GetComponent<SpriteRenderer>();
        if(movement > 0)
        {
            sr.flipX = false;
        }
        else if(movement < 0)
        {
            sr.flipX = true;
        }
        if (Mathf.Abs(movement - 0) > float.Epsilon)
        {
            anim.SetBool("isWalking", true);
        }
        else
        {
            anim.SetBool("isWalking", false);
        }
       

        rb.velocity = new Vector3(movement, rb.velocity.y, 0);


        if (Input.GetKey(KeyCode.S))
        {
            Debug.Log("GOt here");
            //ContactFilter2D myFilter;
            //gameObject.layer = LayerMask.NameToLayer("PlayerDrop");
            //public LayerMask myLayer = 10;
            //
            //ContactFilter2D.SetLayerMask()
            //
            //ContactFilter2D.useLayerMask = true;

            gameObject.layer = 10;
            rb.simulated = false;
            rb.simulated = true;
            
        }
        else
        {
        //    gameObject.layer = 8;
        }

            Vector3 mousePosition = Input.mousePosition;
            mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
            mousePosition.z = transform.position.z;

            transform.GetChild(1).rotation = Quaternion.FromToRotation(Vector3.right, mousePosition - transform.position);
            Quaternion rot = Quaternion.FromToRotation(Vector3.right, mousePosition - transform.position);

        if (Input.GetKey(KeyCode.Mouse0))
        {


            Instantiate(laserPrefab, mousePosition, rot);
        }
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
                    break;
                }

            }

        }

        if(transform.position.y <= -10)
        {
            transform.position = respawnPoint.transform.position;
        }

        
        
    }
}
