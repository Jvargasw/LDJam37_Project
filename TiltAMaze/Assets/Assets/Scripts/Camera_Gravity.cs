using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Gravity : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	
	void Update ()
    {
        
        //smooth rotation
        if (Input.GetKey("a") || Input.GetKey("left"))
        {
            
            transform.Rotate(Vector3.back, 50f * Time.deltaTime);
        }
        else if (Input.GetKey("d") || Input.GetKey("right"))
        {
            transform.Rotate(Vector3.forward, 80f * Time.deltaTime);
        }
        //rotation jumping
        if (Input.GetKeyDown("space"))
        {
            transform.Rotate(0, 0, 180);
        }


        Physics2D.gravity = -transform.up * 9.82f;

	}
}
