﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainMenu_Control : MonoBehaviour
{

    //play button
    public void PlayPress()
    {
        SceneManager.LoadScene("Level1");
    }

    public void ExitPress()
    {
        Application.Quit();
    }
}
