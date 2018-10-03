using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyRocket : MonoBehaviour {

    void OnCollisionEnter2D(Collision2D col)
    {
        //if the "asteroid" makes a collision with a gameObject
        //and if the gameObject is named "rocket" in Unity
        //it will delete that gameObject (rocket)
        if (col.gameObject.name == "rocket")
        {
            Destroy(col.gameObject);
            print("collision");
            print(" ");
        }
    }
}
