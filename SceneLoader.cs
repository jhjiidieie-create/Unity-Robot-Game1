using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    
    public void LoadAutoGame()
    {
        SceneManager.LoadScene("AutoGame");
    }

    public void LoadManualGame()
    {
        SceneManager.LoadScene("ControllerGame");
    }


}
