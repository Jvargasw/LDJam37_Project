using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class player_control : MonoBehaviour
{
    public Sprite player_idle;
    private SpriteRenderer sRenderer;
    private Vector3 lastCheckpoint;
    private Rigidbody2D rbody;
	// Use this for initialization
	void Start ()
    {
        rbody = GetComponent<Rigidbody2D>();
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
        if (Input.GetKeyDown("r"))
        {
            respawnPlayer();
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Hazards")
        {
            //other.gameObject.SetActive(false);
            //restart from a checkpoint if one has been reached
            //else, back to start
            respawnPlayer();

            //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }

        else if (other.gameObject.tag == "Checkpoint")
        {
            //check to make sure the checkpoint isnt already active (meaning the player is going backwards for some reason)
            if (other.gameObject.GetComponent<checkpoint_Control>().isActivated == false)
            {
                lastCheckpoint = other.gameObject.transform.position;
                //set the checkpoint to the "activated" state
                other.gameObject.GetComponent<checkpoint_Control>().isActivated = true;
            }
        }
    }

    void respawnPlayer()
    {
        transform.position = lastCheckpoint;
        rbody.velocity = Vector3.zero;
    }
}
