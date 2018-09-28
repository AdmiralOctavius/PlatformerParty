using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeTime : MonoBehaviour {

    public float lifetime = 3;

	// Use this for initialization
	void Start () {
        Invoke("KillMe", lifetime);
	}
	
	// Update is called once per frame
	void Update () {
	    	
	}

    void KillMe()
    {

        Destroy(gameObject);
    }
}
