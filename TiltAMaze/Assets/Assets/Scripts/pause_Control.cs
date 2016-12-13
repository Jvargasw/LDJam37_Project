using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pause_Control : MonoBehaviour {
    public Canvas pauseMenu;
    public bool isPaused;
	// Use this for initialization
	void Start ()
    {
        Time.timeScale = 1;
        pauseMenu.enabled = false;
        isPaused = false;

	}
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetKeyDown("escape"))
        {
            if (!isPaused)
            {
                //pause the game
                isPaused = true;
                Time.timeScale = 0;
                pauseMenu.enabled = true;

            }
            else
            {
                isPaused = false;
                Time.timeScale = 1;
                pauseMenu.enabled = false;
            }
        }
		
	}

    public void ReturnButton()
    {
        SceneManager.LoadScene("Title");

    }

    public void ExitButton()
    {
        Application.Quit();
    }
}
