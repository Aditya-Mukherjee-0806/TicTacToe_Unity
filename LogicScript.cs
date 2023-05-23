using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LogicScript : MonoBehaviour
{
    int i,c=0;
    Button button;
    public Sprite X;
    public Sprite O;
    public Sprite def;
    bool turn = true;
    char[] move = new char[9];
    public Text result;
    public GameObject gameOverScreen;
    public AudioSource click;
    float pitch = 0.1F;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        i = getButton();
        button = GameObject.FindGameObjectWithTag(i.ToString()).GetComponent<Button>();
        if (result.text == "X Wins!" || result.text == "O Wins!" || result.text == "Draw!")
        {
            onGameOver();
        }
    }

    int getButton()
    {
        return int.Parse(EventSystem.current.currentSelectedGameObject.name);
    }

    public void disableButton()
    {
        if (turn)
        {
            button.image.sprite = X;
            move[i] = 'X';
            turn = false;
        }
        else
        {
            button.image.sprite = O;
            move[i] = 'O';
            turn = true;
        }
        button.enabled = false;
        c++;
        click.pitch = pitch;
        click.Play();
        pitch += 0.05F;
    }

    public void checkWinner()
    {
        //checks rows
        if (move[0] == move[1] && move[1] == move[2])
        {
            result.text = move[0].ToString() + " Wins!";
        }
        else if (move[3] == move[4] && move[4] == move[5])
        {
            result.text = move[3].ToString() + " Wins!";
        }
        else if (move[6] == move[7] && move[7] == move[8])
        {
            result.text = move[6].ToString() + " Wins!";
        }
        //checks columns
        else if (move[0] == move[3] && move[3] == move[6])
        {
            result.text = move[0].ToString() + " Wins!";
        }
        else if (move[1] == move[4] && move[4] == move[7])
        {
            result.text = move[1].ToString() + " Wins!";
        }
        else if (move[2] == move[5] && move[5] == move[8])
        {
            result.text = move[2].ToString() + " Wins!";
        }
        //checks diagonals
        else if (move[0] == move[4] && move[4] == move[8])
        {
            result.text = move[0].ToString() + " Wins!";
        }
        else if (move[2] == move[4] && move[4] == move[6])
        {
            result.text = move[2].ToString() + " Wins!";
        }
        else if(c==9)
        {
            result.text = "Draw!";
        }
    }

    void onGameOver()
    {
        for (int j = 0; j < 9; j++)
        {
            button = GameObject.FindGameObjectWithTag(j.ToString()).GetComponent<Button>();
            if (button.image.sprite == def)
                button.interactable = false;
        }
        gameOver();
    }

    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void gameOver()
    {
        gameOverScreen.SetActive(true);
    }
    public void returnToHome()
    {
        SceneManager.LoadScene("HomeScene");
    }
}