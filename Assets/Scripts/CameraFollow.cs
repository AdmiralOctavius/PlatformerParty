using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {

    public GameObject followObject;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (followObject)
        {
            transform.position = new Vector3(followObject.transform.position.x, followObject.transform.position.y, transform.position.z);
        }
	}
}
