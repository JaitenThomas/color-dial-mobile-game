using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WheelColorManager : MonoBehaviour
{
    public static WheelColorManager instance;


    

    public List<Color> wheelDefaultColors;

    public List<Color> wheel0Colors;
    public List<Color> wheel1Colors;
    public List<Color> wheel2Colors;
    public List<Color> wheel3Colors;
    public List<Color> wheel4Colors;
    public List<Color> wheel5Colors;
    public List<Color> wheel6Colors;
    public List<Color> wheel7Colors;
    public List<Color> wheel8Colors;
    public List<Color> wheel9Colors;
    public List<Color> wheel10Colors;
    public List<Color> wheel11Colors;
    public List<Color> wheel12Colors;
    public List<Color> wheel13Colors;
    public List<Color> wheel14Colors;

    public List<List<Color>> allColorList = new List<List<Color>>();

    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);

        if (instance == null)
        {
            instance = this;
        }

        else
        {
            Destroy(this.gameObject);
        }

        
    }

    public void Start()
    {

        allColorList.Add(wheel0Colors);
        allColorList.Add(wheel1Colors);
        allColorList.Add(wheel2Colors);
        allColorList.Add(wheel3Colors);
        allColorList.Add(wheel4Colors);
        allColorList.Add(wheel5Colors);
        allColorList.Add(wheel6Colors);
        allColorList.Add(wheel7Colors);
        allColorList.Add(wheel8Colors);
        allColorList.Add(wheel9Colors);
        allColorList.Add(wheel10Colors);
        allColorList.Add(wheel11Colors);
        allColorList.Add(wheel12Colors);
        allColorList.Add(wheel13Colors);
        allColorList.Add(wheel14Colors);


        if (SaveManager.instance.state.indexOfSelectedWheel == 0)
        {
            wheelDefaultColors = wheel0Colors;
        }

        else if (SaveManager.instance.state.indexOfSelectedWheel == 1)
        {
            wheelDefaultColors = wheel1Colors;
        }

        else if (SaveManager.instance.state.indexOfSelectedWheel == 2)
        {
            wheelDefaultColors = wheel2Colors;
        }

        else if (SaveManager.instance.state.indexOfSelectedWheel == 3)
        {
            wheelDefaultColors = wheel3Colors;
        }

        else if (SaveManager.instance.state.indexOfSelectedWheel == 4)
        {
            wheelDefaultColors = wheel4Colors;
        }

        else if (SaveManager.instance.state.indexOfSelectedWheel == 5)
        {
            wheelDefaultColors = wheel5Colors;
        }

        else if (SaveManager.instance.state.indexOfSelectedWheel == 6)
        {
            wheelDefaultColors = wheel6Colors;
        }

        else if (SaveManager.instance.state.indexOfSelectedWheel == 7)
        {
            wheelDefaultColors = wheel7Colors;
        }

        else if (SaveManager.instance.state.indexOfSelectedWheel == 8)
        {
            wheelDefaultColors = wheel8Colors;
        }

        else if (SaveManager.instance.state.indexOfSelectedWheel == 9)
        {
            wheelDefaultColors = wheel9Colors;
        }

        else if (SaveManager.instance.state.indexOfSelectedWheel == 10)
        {
            wheelDefaultColors = wheel10Colors;
        }

        else if (SaveManager.instance.state.indexOfSelectedWheel == 11)
        {
            wheelDefaultColors = wheel11Colors;
        }

        else if (SaveManager.instance.state.indexOfSelectedWheel == 12)
        {
            wheelDefaultColors = wheel12Colors;
        }

        else if (SaveManager.instance.state.indexOfSelectedWheel == 13)
        {
            wheelDefaultColors = wheel13Colors;
        }

        else if (SaveManager.instance.state.indexOfSelectedWheel == 14)
        {
            wheelDefaultColors = wheel14Colors;
        }

        
    }
}
