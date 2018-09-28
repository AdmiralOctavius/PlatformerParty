using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turret : MonoBehaviour {

    public GameObject Bullet;
    public float fireRate = 3;

    float lastFireTime = float.MinValue;

    /*
     SOH CAH TOA
     Sine opposite over hypotenuse
     Cosine adjacent over hypotenuse
     Tangent opposite over adjacent
     O - Theta = Angle
     Tan(O) = Opposite/adjacent
     0 = ArcTan( opposite/adjacent)_  
     ArcTan return only 0-90 degrees
     Most math libraries/functions/game engines have Atan2
         * 
         * 
         */
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        //Mathf.Atan2()
	    if(Time.time - (1/fireRate) > lastFireTime)
        {
            Instantiate(Bullet, transform.position, transform.rotation);
            lastFireTime = Time.time;
        }
	}
}
