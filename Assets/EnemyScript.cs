using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour {

    public float patrolDist = 4;
    public bool goingRight = true;
    Vector3 startPosition;

    // Use this for initialization
    void Start()
    {
        startPosition = transform.position;
    }
	
	// Update is called once per frame
	void Update () {
	    if(Mathf.Abs(startPosition.x - transform.position.x) > patrolDist)
        {
            goingRight = !goingRight;
        }

        transform.position += new Vector3(goingRight ? .1f : -.1f, 0, 0);
	}
}
