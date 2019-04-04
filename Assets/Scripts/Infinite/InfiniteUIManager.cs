using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InfiniteUIManager : MonoBehaviour
{
    public static InfiniteUIManager instance;

    public int score;
    public Text scoreText;

    public Text highScoreText;

    public bool gameOver;


    public Canvas gameOverCanvas;

    public Image background;
    public Color gameOverColor;

    public Text currencyText;

   
   


    void Awake()
    {
        instance = this;
    }

    void Start()
    {
        score = 0;
        scoreText.text = score.ToString();

        highScoreText.text = "TOP: " + SaveManager.instance.state.highScore.ToString();
        currencyText.text = "" + SaveManager.instance.state.currency.ToString();

    }

    public void AddScore(int _amount)
    {
        AudioManager.instance.Play("Pop");

        score += _amount;

        if (score > SaveManager.instance.state.highScore)
        {
            highScoreText.text = "TOP: " + score.ToString();
        }

        scoreText.text = score.ToString();
       
    }

    public void AddStar(int _amount)
    {
        SaveManager.instance.state.currency += _amount;
        currencyText.text = "" + SaveManager.instance.state.currency.ToString();
    }

    public void GameOver()
    {
        gameOver = true;

        if (gameOver == true)
        {

            if (score >= SaveManager.instance.state.highScore)
            {
                SaveManager.instance.state.highScore = score;
                highScoreText.text = "TOP: " + SaveManager.instance.state.highScore.ToString();
                if (Social.localUser.authenticated == true)
                {
                    Social.ReportScore(SaveManager.instance.state.highScore, "CgkIgtCfgIwIEAIQCA", (bool success) => { });
                }
            }

            else
            {
                highScoreText.text = "TOP: " + SaveManager.instance.state.highScore.ToString();
            }

            if (SaveManager.instance.state.gameCount < 20)
            {
                SaveManager.instance.state.gameCount += 1;
            }

            if (SaveManager.instance.state.gameCount == 20)
            {
                UnityAdManager.instance.ShowAfterGameAd();
                SaveManager.instance.state.gameCount = 0;
            }

            AudioManager.instance.Play("Over");

           // background.color = gameOverColor;

           

            // Debug.Log("Game Over");

            InfiniteGameManager.instance.started = false;


            gameOverCanvas.gameObject.SetActive(true);


           WheelController.instance.enabled = false;

           


           SaveManager.instance.Save();
        }
    }


}
