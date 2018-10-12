using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Globals : MonoBehaviour {

    public static GameObject playerObject;
    public static GameObject globalsObject;
    public GameObject player;

    public static List<CheckPoint> checkPointList = null;
    private List<CheckPoint> checkpoints = null;

    // Use this for initialization
    void Awake () {
        globalsObject = gameObject;

        playerObject = player;
        if (!playerObject)
        {
            //This can easily grab the player via tag
            playerObject = GameObject.FindGameObjectWithTag("Player");
        }
        if (!playerObject)
        {
            //This grabs the player gameobject by grabbing the playerMove script on the player, which is unique in this scenario
            playerObject = GameObject.FindObjectOfType<Playermove>().gameObject;
        }

        checkpoints = new List<CheckPoint>(FindObjectsOfType<CheckPoint>());
        checkPointList = checkpoints;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
