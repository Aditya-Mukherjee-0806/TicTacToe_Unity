using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SelectDifficultyScript : MonoBehaviour
{
    public Text difficultyText;
    public Slider difficultySlider;
    public Color orange;
    public void setDifficultyText()
    {
        float value = difficultySlider.value;
        if (value == 0)
        {
            difficultyText.color = Color.green;
            difficultyText.text = "Easy";
        }
        else if (value == 1)
        {
            difficultyText.color = Color.yellow;
            difficultyText.text = "Medium";
        }
        else if (value == 2)
        {
            difficultyText.color = orange;
            difficultyText.text = "Hard";
        }
        else if (value == 3)
        {
            difficultyText.color = Color.red;
            difficultyText.text = "Impossible";
        }
    }

    public void openSinglePlayer()
    {
        SceneManager.LoadScene("SinglePlayerScene");
    }
}