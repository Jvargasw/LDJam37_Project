using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Gravity : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetKeyDown("a") || Input.GetKeyDown("left"))
        {
            transform.Rotate(0,0, -90);
        }
        if (Input.GetKeyDown("d") || Input.GetKeyDown("right"))
        {
            transform.Rotate(0, 0, 90);
        }


        Physics2D.gravity = -transform.up * 9.82f;

	}
}
