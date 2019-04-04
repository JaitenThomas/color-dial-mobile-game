using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelChanger : MonoBehaviour
{
    public static LevelChanger instance;

    public Animator animator;

    private string levelToLoad;

    public bool isPlay;

    private void Awake()
    {
        instance = this;
    }

    public void FadeToLevel(string levelName)
    {

        levelToLoad = levelName;

        if (levelToLoad == "Main")
        {
            if (SaveManager.instance.state.first == false)
            {

                LevelChanger.instance.FadeToLevel("Tutorial");

                SaveManager.instance.state.first = true;
                SaveManager.instance.Save();
            }
        }

        animator.SetTrigger("FadeOut");
    }

    public void FadeToSelf()
    {
        levelToLoad = SceneManager.GetActiveScene().name;
        animator.SetTrigger("FadeOut");
    }

    public void OnFadeComplete()
    {

         SceneManager.LoadScene(levelToLoad);

    }



 
}
