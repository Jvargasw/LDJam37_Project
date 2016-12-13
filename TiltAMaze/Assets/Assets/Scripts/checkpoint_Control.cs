using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkpoint_Control : MonoBehaviour
{
    private SpriteRenderer sRenderer;
    public bool isActivated;
    public Sprite activeCheck;
	// Use this for initialization
	void Start ()
    {
        isActivated = false;
        sRenderer = GetComponent<SpriteRenderer>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (isActivated && sRenderer.sprite != activeCheck)
        {
            sRenderer.sprite = activeCheck;
        }
	}
}
