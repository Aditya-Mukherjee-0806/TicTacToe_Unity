using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChangeScript : MonoBehaviour
{
    public void Play()
    {
        SceneManager.LoadScene("ModeScene");
    }

    public void Exit()
    {
        Application.Quit();
    }
}
