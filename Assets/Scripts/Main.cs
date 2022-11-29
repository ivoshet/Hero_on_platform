using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//the script for level reloading

public class Main : MonoBehaviour
{
    public void Lose()
    {
        //for load current scene
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
