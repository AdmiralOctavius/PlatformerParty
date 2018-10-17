using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelChange : MonoBehaviour {

    public string goToLevel;

	void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject == Globals.playerObject)
        {
            SceneManager.LoadScene(goToLevel);
        }
    }
}
