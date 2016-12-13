using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HTP_controller : MonoBehaviour
{
    //probably could've used the pause control/ end control script. But oh well. Would rather have a different script for each menu in case of future modification
    public void ReturnButton()
    {
        SceneManager.LoadScene("Title");

    }

}

