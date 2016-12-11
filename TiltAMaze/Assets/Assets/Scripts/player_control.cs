using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Hazards")
        {
            //other.gameObject.SetActive(false);
            //restart from a checkpoint if one has been reached

            //else restart the level
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
