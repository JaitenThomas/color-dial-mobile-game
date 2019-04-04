using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialManager : MonoBehaviour
{

    void Start()
    {

    }

    void Update()
    {

    }

    public void ToScene(string _name)
    {


        LevelChanger.instance.FadeToLevel(_name);
        Debug.Log("Menu");
    }
}
