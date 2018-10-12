using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteSpin : MonoBehaviour {
    float newXScale;
    float currentXScale;
    // Use this for initialization
    void Start () {
        newXScale = transform.localScale.x;
        currentXScale = newXScale;
	}
	
	// Update is called once per frame
	void Update () {
        //currentXScale = newXScale + Random.Range(-1, 1);
        //currentXScale = Mathf.Sin(Time.time) * newXScale;
        currentXScale = Mathf.PingPong(Time.time * 3, newXScale);
        transform.localScale = new Vector3(currentXScale, transform.localScale.y, transform.localScale.z);
	}
}
