using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelController : MonoBehaviour
{
    public static LevelController instance;

    public int maxLevel;
    public int curLevel;

    public Text curLevelText;

    public void Awake()
    {
        instance = this;
    }

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


        MenuWheel.instance.SetMenuWheelSpeed();
        curLevelText.text = "" + curLevel.ToString();
    }

    public void IncreaseLevel()
    {

        if (curLevel == maxLevel)
        {
            curLevel = 1;
            curLevelText.text = "" + curLevel.ToString();

        }

        else
        {
            curLevel += 1;
            curLevelText.text = "" + curLevel.ToString();
        }

        MenuWheel.instance.SetMenuWheelSpeed();

    }

    public void DecreaseLevel()
    {

        if (curLevel == 1)
        {
            curLevel = maxLevel;
            curLevelText.text = "" + curLevel.ToString();
            MenuWheel.instance.SetMenuWheelSpeed();
        }

        else
        {
            curLevel -= 1;
            curLevelText.text = "" + curLevel.ToString();
            MenuWheel.instance.SetMenuWheelSpeed();

        }

        MenuWheel.instance.SetMenuWheelSpeed();
    }


    public void SetCurrentLevel()
    {
        SaveManager.instance.state.maxLevel = maxLevel;
        SaveManager.instance.state.level = curLevel;

    }


}
