using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPoint : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject != Globals.playerObject)
        {
            return;
        }
        transform.GetChild(0).GetComponent<SpriteRenderer>().enabled = true;
        Globals.playerObject.GetComponent<Playermove>().SetRespawnPoint(this.gameObject);

        foreach(CheckPoint c in Globals.checkPointList)
        {
            if (c == this)
            {
                continue;
            }
            c.gameObject.transform.GetChild(0).GetComponent<SpriteRenderer>().enabled = false;
        }
    }

    void OnTriggerExit2D(Collider2D col)
    {

    }

    void OnTriggerStay2D(Collider2D col)
    {

    }
}
