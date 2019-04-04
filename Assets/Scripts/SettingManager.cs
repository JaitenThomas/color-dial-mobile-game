using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SettingManager : MonoBehaviour
{

    public int maxLevel;
    public int curLevel;

    public Text curLevelText;

    void Start()
    {
        curLevel = SaveManager.instance.state.level;
        maxLevel = SaveManager.instance.state.maxLevel;

        if (maxLevel == 0)
        {
            maxLevel = curLevel;
           
        }

        else if (maxLevel < curLevel)
        {
            maxLevel = curLevel;
        }
       

        curLevelText.text = "Level: " + curLevel.ToString();



    }


    public void ToHome()
    {
        SaveManager.instance.Save();
        SceneController.instance.ToScene("Menu");
    }

    public void IncreaseLevel()
    {

        if (curLevel >= maxLevel)
        {
            return;
        }

        else
        {
            curLevel += 1;
            curLevelText.text = "Level: " + curLevel.ToString();
        }

       
    }

    public void DecreaseLevel()
    {
       
        if (curLevel <= 1)
        {
            return;

        }

        else
        {
            curLevel -= 1;
            curLevelText.text = "Level: " + curLevel.ToString();
            Debug.Log(curLevel);
        }
    }

    public void SetCurrentLevel()
    {
        SaveManager.instance.state.maxLevel = maxLevel;
        SaveManager.instance.state.level = curLevel;
       
    }
}
