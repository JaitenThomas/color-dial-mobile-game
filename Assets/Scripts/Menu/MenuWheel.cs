using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuWheel : MonoBehaviour
{
    public static MenuWheel instance;

    public float speed;

    public float minSpeed;

    public bool direction;

    public GameObject wheel;

    private void Awake()
    {
        instance = this;
    }

    void Start()
    {
    }

    public void SetMenuWheelSpeed()
    {
        speed = minSpeed;

        if (LevelController.instance.curLevel != 1 && LevelController.instance.curLevel < 50)
        {
            speed = speed + 1.0f * LevelController.instance.curLevel;
        }
        else if (LevelController.instance.curLevel == 1)
        {
            speed = minSpeed;
        }
        else if (LevelController.instance.curLevel >= 50)
        {
            speed = 130;
        }
    }

    void Update()
    {
        if (direction == false)
        {
            wheel.transform.Rotate(0, 0, speed * Time.deltaTime);
        }

        else if (direction == true)
        {
            wheel.transform.Rotate(0, 0, -speed * Time.deltaTime);
        }
       
    }

    public void Direction()
    {
        direction = !direction;
    }
}
