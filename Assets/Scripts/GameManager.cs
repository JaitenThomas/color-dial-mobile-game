using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

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

    void Update()
    {
       
    }

    public void StartGame()
    {
        
        if (started == false && UIManager.instance.gameOver == false)
        {
            

            //Debug.Log("1");
            started = true;

            marker.GetComponent<Marker>().enabled = true;

            marker.GetComponent<Marker>().ChangeColor();
            
            
            wheelController.enabled = true;

        }

        else if (UIManager.instance.gameOver == true)
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
        LevelChanger.instance.FadeToLevel("Menu");
    }
}
