using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControllerScript : MonoBehaviour {

    GameObject player;
    GameObject playerCam;
    bool gameOver;

    // Use this for initialization
    void Start () {
        /*stuff to initialize
         * player reference?
         * to get raycast and highlight the selected jack
         * so maybe we need a var for the reference to the game object being highlighted?
         */
        player = GameObject.FindGameObjectsWithTag("Player")[0];
        playerCam = GameObject.FindGameObjectsWithTag("Player")[0].transform.GetChild(0).gameObject;
        gameOver = false;
    }
	
	// Update is called once per frame
	void Update () {
        if (!gameOver) {
            RaycastHit jackFinderHit;
            Ray jackRay = new Ray(playerCam.transform.position, playerCam.transform.rotation.ToEulerAngles());
            Debug.DrawRay(playerCam.transform.position, playerCam.transform.rotation.ToEulerAngles() * new Vector3(10,10,10));
            if (Physics.Raycast(jackRay, out jackFinderHit)){
                if (jackFinderHit.collider.tag == "jack") {
                    dostuff();
                }
            }
        }
    }

    void dostuff(){
        player.transform.Translate(Vector3.up * Time.deltaTime, Space.World);
    }


        /*check for raycast result
         * if it hits a jack, the highlight it
         * same for a plug hole
         * where is animation handled? player controller?
         * if highlighted and player clicks, run method in player script w/ info abt what it is
         * if already holding jack, let go of other jack
         * if not holding jack, do not highlight holes?
         */
}
