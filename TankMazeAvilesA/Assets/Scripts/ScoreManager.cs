using System.Collections;
using System.Collections.Generic;
using TMPro; // add this to work with text mesh pro
using UnityEngine.SceneManagement;//add this to work with SceneMangager to load or reload screens
using UnityEngine;

public class ScoreManager : MonoBehaviour
{

    public static bool gameOver;
    public static bool won;
    public static int score;

    public TMP_Text textbox;
    public int scoreToWin;
    // Start is called before the first frame update
    void Start()
    {
        gameOver = false;
        won = false;
        score = 0;

    }

    // Update is called once per frame
    void Update()
    {
        if (!gameOver)
        {
            textbox.text = "Score: " + score;
        }

        if (score >= scoreToWin)  //hit crt+R twice to rename all instances of a varible

        {
            won = true;
            gameOver = true;
        }
        if (gameOver)
        {
            if (won)
            {
                textbox.text = "You win!\n Press R to Try Again!";
            }
            else
            {
                textbox.text = "You lose!\n Press R to Try Again!";
            }
            //if the game is over and they press the r key
            if (Input.GetKeyDown(KeyCode.R))
            {
                //reloads the current scene
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
        }
    }
}
