using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;  

public class CanvasBtn : MonoBehaviour
{
    public void NextScene()
    {
        SceneManager.LoadScene("past_scene");
    }

    public void PastScene()
    {
        SceneManager.LoadScene("first_scene");
    }
}
