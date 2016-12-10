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
        if (Input.GetKeyDown("q"))
        {
            transform.Rotate(0,0, 90);
        }


        Physics2D.gravity = -transform.up * 9.82f;

	}
}
