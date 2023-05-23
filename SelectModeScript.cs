using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SelectModeScript : MonoBehaviour
{
    public void OpenMultiPlayer()
    {
        SceneManager.LoadScene("MultiPlayerScene");
    }
    
    public void OpenDifficultySelection()
    {
        SceneManager.LoadScene("DifficultyScene");
    }
}
