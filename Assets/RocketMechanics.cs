using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketMechanics : MonoBehaviour 
{

    public float rocketXPosition;   
    public float rocketYPosition;
    public Rigidbody2D rb2d;
    public KeyCode up;              //up arrow in Inspector
    public KeyCode down;            //down arrow in Inspector
    public KeyCode left;            //left arrow in Inspector
    public KeyCode right;           //right arrow in Inspector

    // Use this for initialization
    void Start()
    {
        //grabs the Rigidbody component of our gameObject, rocket.
        rb2d = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(up))
        {
            UpArrowPressed();

        }
        if (Input.GetKey(down))
        {
            DownArrowPressed();
        }
        if (Input.GetKey(left))
        {
            LeftArrowPressed();

        }
        if (Input.GetKey(right))
        {
            RightArrowPressed();

        }

    }

    //once the up arrow is pressed, this function will use the RigidBody2D variable, rb2d,
    //(which holds the RigidBody component of our gameObject, rocket)
    //and will add a force in the positive y direction
    void UpArrowPressed()
    {
        rb2d.AddForce(transform.up, ForceMode2D.Impulse);
    }

    //once the down arrow is pressed, this function will use the RigidBody2D variable, rb2d,
    //(which holds the RigidBody component of our gameObject, rocket)
    //and will add a force in the negative y direction
    void DownArrowPressed()
    {
        rb2d.AddForce(-transform.up, ForceMode2D.Impulse);
    }

    //once the left arrow is pressed, this funciton will calculate the rocket's current x and y position
    //and store them into rocketXPosition and rocketYPosition to be used for later
    //the rocket's y position will not change, but the x position will drecrease .2 in the negative x direction
    void LeftArrowPressed()
    {
        rocketXPosition = gameObject.transform.position.x;
        rocketYPosition = gameObject.transform.position.y;
        gameObject.transform.position = new Vector2((float)(rocketXPosition - .2), rocketYPosition - 0);
        //rocket.transform.Rotate(Vector3.forward, (UnityEngine.Space).5);
    }

    //once the right arrow is pressed, this function will calculate the rocket's current x and y position
    //and store them into rocketXPosition and rocketYPosition to be used for later
    //the rocket's y position will not change, but the x position will increase .2 in the positive x direction
    void RightArrowPressed()
    {
        rocketXPosition = gameObject.transform.position.x;
        rocketYPosition = gameObject.transform.position.y;

        gameObject.transform.position = new Vector2((float)(rocketXPosition + .2), rocketYPosition + 0);
        //rocket.transform.Rotate(Vector3.back, (UnityEngine.Space).5);
    }

}
