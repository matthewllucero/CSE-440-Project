using System.Collections;
using System.Collections.Generic;
using UnityEngine;



/*
 * NOTE: This script is meant for the camera to follow the rocket during the game.
 *       Still working on it. Tried using the offset of the initial positions.
 *       Will have to come back to this.
 *       If I have the rocket be a parent object to the Main Camera, the camera
 *       will stop rendering once the rocket is deleted when it collides with an asteroid.
*/

public class FollowRocket : MonoBehaviour {

    public GameObject rocket;
    public Vector2 rocketXPosition;
    public Vector2 rocketYPosition;

    void Follow() {
        print(gameObject.transform.position.x);
        print(gameObject.transform.position.y);

        print(" ");

        print(rocket.transform.position.x);
        print(rocket.transform.position.y);
    }

}
