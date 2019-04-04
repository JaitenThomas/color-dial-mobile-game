using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public static UIManager instance;

    public Text remainingCountText;
    public int remainingCount;

    public Text levelText;

    public bool gameOver;

    public GameObject wheel;


    public bool levelCompleted;


    public Canvas gameOverCanvas;

    public Color gameOverColor;
    public Color levelPassColor;
    public Color defaultColor;

    public Text starText;

    public GameObject marker;
    public GameObject outline;



    public GameObject startButton;

    public int level;



    public Image background;
    public Color markerDefaultColor;
    public Color defaultBackgroundColor;

    public bool notStar;


    void Awake()
    {
        instance = this;
    }

    void Start()
    {
        remainingCount = SaveManager.instance.state.level;
        remainingCountText.text = remainingCount.ToString();

        gameOverCanvas.gameObject.SetActive(false);

        levelText.text = "Level: " + SaveManager.instance.state.level.ToString();

        starText.text = "" + SaveManager.instance.state.currency.ToString();

        level = SaveManager.instance.state.level;

    }

    public void ReduceCounter(int _amount)
    {
        if (remainingCount > 0)
        {
            remainingCount += _amount;
            if (remainingCount > 0)
            {
                AudioManager.instance.Play("Pop");
            }
           
        }

        if (remainingCount <= 0)
        {
            LevelCompleted();
        }
       
        remainingCountText.text = remainingCount.ToString();
    }

    public void LevelCompleted()
    {
        levelCompleted = true;

        if (wheel.transform.parent.GetComponent<WheelController>().speed < 125)
        {
            wheel.transform.parent.GetComponent<WheelController>().speed += 1.0f;
        }

        AudioManager.instance.Play("Completed");


        if (SaveManager.instance.state.gameCount < 20)
        {
            SaveManager.instance.state.gameCount += 1;
        }

        if(SaveManager.instance.state.gameCount == 20)
        {
            UnityAdManager.instance.ShowAfterGameAd();
            SaveManager.instance.state.gameCount = 0;
        }

        

        GameManager.instance.started = false;

        startButton.SetActive(false);

        marker.GetComponent<Marker>().firstTime = false;
     
        marker.GetComponent<Marker>().ResetTempColors();

        // background.color = levelPassColor;


        StartCoroutine(WaitForLevelCompleted());


    }

    IEnumerator WaitForLevelCompleted()
    {


       


        if (level >= SaveManager.instance.state.maxLevel)
        {
            SaveManager.instance.state.maxLevel = level;

            if (Social.localUser.authenticated == true)
            {
                Social.ReportScore(SaveManager.instance.state.maxLevel, "CgkIgtCfgIwIEAIQBw", (bool success) => { });
            }
        }

        level += 1;

       


        //turn off during transition
        marker.GetComponent<Marker>().enabled = false;
        WheelController.instance.enabled = false;
        


        yield return new WaitForSeconds(1.0f);

        wheel.transform.parent.GetComponent<WheelManager>().MoveOut();
       

        yield return new WaitForSeconds(0.5f);

        marker.GetComponent<SpriteRenderer>().color = markerDefaultColor;
        outline.GetComponent<SpriteRenderer>().color = markerDefaultColor;

        // background.color = defaultColor;

        AddLevel();
        remainingCount = SaveManager.instance.state.level;
        remainingCountText.text = remainingCount.ToString();


        //Set the wheel back to default color and rotation
        wheel.transform.rotation = Quaternion.Euler(0, 0, 12);

        SaveManager.instance.Save();

    }

   

  

    public void AddLevel()
    {
        SaveManager.instance.state.level += 1;
        levelText.text = "Level: " + SaveManager.instance.state.level.ToString();
    }

    public void AddStar(int _amount)
    {
        SaveManager.instance.state.currency += _amount;
        starText.text = "" + SaveManager.instance.state.currency.ToString();
    }

    public void GameOver()
    {
        gameOver = true;

        if (gameOver == true)
        {

            if (level >= SaveManager.instance.state.maxLevel)
            {
                SaveManager.instance.state.maxLevel = level;
                GPG_MANAGER.instance.OnAddScoreToLeaderboard(SaveManager.instance.state.maxLevel, "CgkIgtCfgIwIEAIQAA");
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

          

            // Debug.Log("Game Over");

            gameOverCanvas.gameObject.SetActive(true);

            GameManager.instance.started = false;
            WheelController.instance.enabled = false;

            AudioManager.instance.Play("Over");

           
 
           // background.color = gameOverColor;

            SaveManager.instance.Save();
        }
    }

   

}
