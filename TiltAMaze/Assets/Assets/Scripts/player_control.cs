using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class player_control : MonoBehaviour
{
    public Sprite player_idle;
    private SpriteRenderer sRenderer;
    private Vector3 lastCheckpoint;
	// Use this for initialization
	void Start ()
    {
        lastCheckpoint = transform.position;
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

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Hazards")
        {
            //other.gameObject.SetActive(false);
            //restart from a checkpoint if one has been reached
            //else, back to start
            transform.position = lastCheckpoint;

            //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }

        else if (other.gameObject.tag == "Checkpoint")
        {
            lastCheckpoint = other.gameObject.transform.position;
            other.gameObject.SetActive(false);
        }
    }
}
