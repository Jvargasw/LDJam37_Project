using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera_control : MonoBehaviour {

    private Transform player;
	// Use this for initialization
	void Start ()
    {
        player = GameObject.Find("Player").transform;
	}
	
	// Update is called once per frame
	void Update ()
    {
        Vector3 pPosition = player.position;
        pPosition.z = transform.position.z;
        transform.position = pPosition;
	}
}
