using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turret : MonoBehaviour {

    public GameObject Bullet;
    public float fireRate = 3;
    public bool useLineOfSight;
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

        GameObject player = Globals.playerObject;

        Vector3 dif = player.transform.position - transform.position;
        float angle = Mathf.Rad2Deg * Mathf.Atan2(dif.y, dif.x);
        transform.eulerAngles = new Vector3(0, 0, angle);

        //Mathf.Atan2()
	    if(Time.time - (1/fireRate) > lastFireTime)
        {
            Instantiate(Bullet, transform.position, transform.rotation);
            lastFireTime = Time.time;
        }
	}
}
