using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControllerScript : MonoBehaviour {

    GameObject player;

    // Use this for initialization
    void Start () {
		/*stuff to initialize
         * player reference?
         * to get raycast and highlight the selected jack
         * so maybe we need a var for the reference to the game object being highlighted?
         */ 
         player = GameObject.FindGameObjectsWithTag("Player")[0];
    }
	
	// Update is called once per frame
	void Update () {
        player.transform.Translate(Vector3.up * Time.deltaTime, Space.World);
        /*check for raycast result
         * if it hits a jack, the highlight it
         * same for a plug hole
         * where is animation handled? player controller?
         * if highlighted and player clicks, run method in player script w/ info abt what it is
         * if already holding jack, let go of other jack
         * if not holding jack, do not highlight holes?
         */
    }
}
