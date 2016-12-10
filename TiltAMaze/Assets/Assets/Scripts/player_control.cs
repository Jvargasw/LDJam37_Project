using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_control : MonoBehaviour
{
    public Sprite player_idle;
    private SpriteRenderer sRenderer;
	// Use this for initialization
	void Start ()
    {
        sRenderer = GetComponent<SpriteRenderer>();
        if (sRenderer.sprite == null)
        {
            sRenderer.sprite = player_idle; //set to idle sprite if no sprite is found
        } 
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}
}
