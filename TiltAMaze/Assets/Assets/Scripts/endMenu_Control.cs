using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class endMenu_Control : MonoBehaviour
{

	// Use this for initialization
	void Start ()
    {
		//possibly add a disable on the button until a sound plays + particle effect later?
	}
    //return to main menu button
    public void ReturnPress()
    {
        SceneManager.LoadScene("Title");
    }
	

}
