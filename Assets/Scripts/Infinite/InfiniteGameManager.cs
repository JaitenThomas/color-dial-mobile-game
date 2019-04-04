using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InfiniteGameManager : MonoBehaviour
{ 
    public static InfiniteGameManager instance;

    public bool started;

    public bool firstPressed;

    public WheelController wheelController;

    public GameObject marker;


    private void Awake()
    {
        instance = this;
    }

    void Start()
    {

    }

   

    public void StartGame()
    {
        if (started == false && InfiniteUIManager.instance.gameOver == false)
        {
           
            started = true;

            marker.GetComponent<InfiniteMarker>().enabled = true;
            marker.GetComponent<InfiniteMarker>().ChangeColor();

        
            wheelController.enabled = true;
        }

        else if (InfiniteUIManager.instance.gameOver == true)
        {
            RestartScene();
        }
    }

    public void RestartScene()
    {
         LevelChanger.instance.FadeToSelf();
    }

    public void BackToMenu()
    {
        Debug.Log("Home");

        LevelChanger.instance.FadeToLevel("Menu");
    }
}
